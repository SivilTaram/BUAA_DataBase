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
    public partial class WareHouseManager : MetroForm
    {
        string worker_id;
        private static MySqlCommand com;
        private DataTable data_set;
        private MetroForm login;

        public WareHouseManager(MySqlDataReader dataReader,MetroForm _login)
        {
            InitializeComponent();
            login = _login;
            this.FormClosing += WareHouseManager_FormClosing;
            //We last don't have it as a id but a name for reading.
            worker_id = dataReader.GetString("worker_name");
            this.Text = "欢迎回来，" + dataReader.GetString("worker_name");
            dataReader.Close();
            data_set = new DataTable();
            DataGridViewButtonColumn request_column = new DataGridViewButtonColumn();
            request_column.HeaderText = "请求";
            //gigUrlColumn.Name = "Gig Url name";
            request_column.Text = "入库";
            request_column.UseColumnTextForButtonValue = true;
            request_column.Width = 106;
            WHdataGridView.Columns.Add(request_column);
            WHdataGridView.DataSource = FillDataGrid();
            WHdataGridView.DefaultCellStyle.SelectionBackColor = Color.SkyBlue;
            WHdataGridView.DefaultCellStyle.SelectionForeColor = Color.White;

        }

        private void WareHouseManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Close();
        }

        public DataTable FillDataGrid()
        {
            string selectStatement = "select * from ReceivList";
            com = new MySqlCommand(selectStatement, Login.con);
            MySqlDataReader data_adapt = com.ExecuteReader();
            DataTable temp = new DataTable();
            temp.Load(data_adapt);
            temp.Columns["worker_id"].ColumnName = "接货人员";
            temp.Columns["order_id"].ColumnName = "订单编号";
            temp.Columns["receive_time"].ColumnName = "接货时间";
            data_set = temp;
            data_adapt.Close();
            return temp;
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            WHdataGridView.DataSource = null;
            WHdataGridView.DataSource = FillDataGrid();
        }

        private void WHdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string _order_id = WHdataGridView.Rows[e.RowIndex].Cells["订单编号"].Value.ToString();
                string selectStatement = "select * from cargo where cargo_id = \"" + _order_id + "\"";
                com = new MySqlCommand(selectStatement, Login.con);
                com.ExecuteNonQuery();
                MySqlDataReader dataReader = com.ExecuteReader();
                if (dataReader.HasRows && dataReader.Read() && dataReader.GetString(0) != null)
                {
                    Cargo cargo = new Cargo(_order_id, worker_id,dataReader);
                    cargo.ShowDialog();
                    if (cargo.DialogResult == DialogResult.Yes)
                    {
                        WHdataGridView.DataSource = null;
                        WHdataGridView.DataSource = FillDataGrid();
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "该货物好像不存在货仓里哦~", "查询异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataReader.Close();
                }
            }
        }
    }
}
