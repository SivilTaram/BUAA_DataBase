using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using MySql.Data.MySqlClient;
using MetroFramework.Controls;

namespace DataBaseLogistic
{
    public partial class ReceiveManager : MetroForm
    {
        string worker_id;
        private static MySqlCommand com;
        private MetroForm login;

        public ReceiveManager(MySqlDataReader dataReader,MetroForm _login)
        {
            InitializeComponent();
            login = _login;
            this.FormClosing += ReceiveManager_FormClosing;
            worker_id = dataReader.GetString("worker_name");
            this.Text = "欢迎回来，" + dataReader.GetString("worker_name");
            dataReader.Close();
            DataGridViewButtonColumn request_column = new DataGridViewButtonColumn();
            request_column.HeaderText = "请求";
            //gigUrlColumn.Name = "Gig Url name";
            request_column.Text = "确认";
            request_column.UseColumnTextForButtonValue = true;
            request_column.Width = 106;
            WaitToConfrimDataGridView.Columns.Add(request_column);
            WaitToConfrimDataGridView.DataSource = FillDataGrid();

            DataGridViewButtonColumn request2_column = new DataGridViewButtonColumn();
            request2_column.HeaderText = "请求";
            //gigUrlColumn.Name = "Gig Url name";
            request2_column.Text = "接货成功";
            request2_column.UseColumnTextForButtonValue = true;
            request2_column.Width = 106;
            CheckGridView.Columns.Add(request2_column);
            CheckGridView.DataSource = FillCheckData();
        }

        private void ReceiveManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Close();
        }

        public DataTable FillDataGrid()
        {
            string selectStatement = "select order_id,Client.user_name,user_phone,user_addr from OrderList,Client where OrderList.user_id = Client.user_id and OrderList.state = \"placed\" ";
            com = new MySqlCommand(selectStatement, Login.con);
            MySqlDataReader data_adapt = com.ExecuteReader();
            if (data_adapt.HasRows)
            {
                DataTable temp = new DataTable();
                temp.Load(data_adapt);
                data_adapt.Close();
                temp.Columns["order_id"].ColumnName = "订单编号";
                temp.Columns["user_name"].ColumnName = "用户姓名";
                temp.Columns["user_phone"].ColumnName = "用户联系方式";
                temp.Columns["user_addr"].ColumnName = "用户地址";
                return temp;
            }
            else
            {
                data_adapt.Close();
                return new DataTable();
            }
        }
 
        private void WaitToConfrimDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string _order_id = WaitToConfrimDataGridView.Rows[e.RowIndex].Cells["订单编号"].Value.ToString();
                string selectStatement = "insert into checklist values(\"" + worker_id + "\",\"" + _order_id + "\",localtimestamp())";
                com = new MySqlCommand(selectStatement, Login.con);
                com.ExecuteNonQuery();
                string updataStatement = "update orderlist set checkOrder_time = localtimestamp() where order_id = \""+_order_id+"\"";
                com = new MySqlCommand(updataStatement, Login.con);
                com.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(this,"确认订单成功","请求");
                WaitToConfrimDataGridView.DataSource = null;
                WaitToConfrimDataGridView.DataSource = FillDataGrid();
            }
        }

        public DataTable FillCheckData()
        {
            string selectStatement = "select * from checklist";
            com = new MySqlCommand(selectStatement, Login.con);
            MySqlDataReader data_adapt = com.ExecuteReader();
            if (data_adapt.HasRows)
            {
                DataTable temp = new DataTable();
                temp.Load(data_adapt);
                temp.Columns["worker_id"].ColumnName = "订单确认人";
                temp.Columns["order_id"].ColumnName = "订单编号";
                temp.Columns["check_time"].ColumnName = "订单确认时间";
                data_adapt.Close();
                return temp;
            }
            else
            {
                data_adapt.Close();
                return new DataTable();
            }
            data_adapt.Close();
        }

        private void CheckGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string _order_id = CheckGridView.Rows[e.RowIndex].Cells["订单编号"].Value.ToString();
                string selectStatement = "insert into receivlist values(\"" + worker_id + "\",\"" + _order_id + "\",localtimestamp())";
                com = new MySqlCommand(selectStatement, Login.con);
                com.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(this, "确认接货成功", "请求");
                CheckGridView.DataSource = null;
                CheckGridView.DataSource = FillCheckData();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            CheckGridView.DataSource = null;
            CheckGridView.DataSource = FillCheckData();
            WaitToConfrimDataGridView.DataSource = null;
            WaitToConfrimDataGridView.DataSource = FillDataGrid();
        }
    }
}
