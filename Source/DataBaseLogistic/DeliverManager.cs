using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;
using MetroFramework;
using MetroFramework.Controls;


namespace DataBaseLogistic
{
    public partial class DeliverManager : MetroForm
    {

        string worker_id;
        private static MySqlCommand com;
        private DataTable data_set;
        private MetroTile[,] MetroTileA = new MetroTile[10, 20];
        private string cargo_name = "233";
        private MetroForm login;

        public DeliverManager(MySqlDataReader data_reader,MetroForm _login)
        {
            InitializeComponent();
            login = _login;
            this.FormClosing += DeliverManager_FormClosing;
            worker_id = data_reader.GetString("worker_name");
            this.Text = "欢迎回来，" + worker_id;
            data_reader.Close();
            InitialTable();
            FillComboBox();
            UpdataTable(cargo_name);
        }

        private void DeliverManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Close();
        }

        public DataTable FillDataGrid()
        {
            string selectStatement = "select * from cargoList";
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

        public void InitialTable()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    MetroTileA[i, j] = new MetroTile();
                    MetroTile temp = MetroTileA[i, j];
                    temp.ActiveControl = null;
                    temp.Size = new System.Drawing.Size(20, 20);
                    temp.TabIndex = i * 10 + j;
                    temp.Tag = new int[] { i, j };
                    temp.Cursor = System.Windows.Forms.Cursors.Hand;
                    temp.Click += new System.EventHandler(this.MetroTile_Click);
                    TableLayOut.Controls.Add(temp);
                }
            }
        }

        public void UpdataTable(string _cargo_name)
        {
            string selectStatement = "select * from cargolist where warehouse_id = \"" + _cargo_name + "\"";
            com = new MySqlCommand(selectStatement, Login.con);
            com.ExecuteNonQuery();
            MySqlDataReader dataReader = com.ExecuteReader();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    MetroTileA[i, j].Style = MetroColorStyle.Green;
                }
            }
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    int i = dataReader.GetInt32("row_id");
                    int j = dataReader.GetInt32("column_id");
                    MetroTileA[i, j].Style = MetroColorStyle.Red;
                }
            }
            dataReader.Close();
        }

        public void MetroTile_Click(object sender, EventArgs e)
        {
            MetroTile click_metrotile = (MetroTile)sender;
            int[] data = (int[])click_metrotile.Tag;
            int i = data[0];
            int j = data[1];
        }

        public void FillComboBox()
        {
            string selectStatement = "select distinct cargo_id from cargolist where warehouse_id = \"" + cargo_name + "\"";
            com = new MySqlCommand(selectStatement, Login.con);
            MySqlDataReader data_reader = com.ExecuteReader();
            CargoComboBox.Items.Clear();
            if (data_reader.HasRows)
            {
                while (data_reader.Read())
                {
                    CargoComboBox.Items.Add(data_reader.GetString(0));
                }
            }
            data_reader.Close();
        }

        private void GetAllButton_Click(object sender, EventArgs e)
        {
            string text = CargoComboBox.Text;
            if (CargoComboBox.Items.Count!=0 && text!="")
            {
                string selectStatement = "select * from cargoList where warehouse_id = \"" + cargo_name + "\" and " + "cargo_id = \"" + text + "\"";
                com = new MySqlCommand(selectStatement, Login.con);
                MySqlDataReader data_reader = com.ExecuteReader();
                if (data_reader.HasRows)
                {
                    while (data_reader.Read())
                    {
                        int i = Convert.ToInt32(data_reader.GetString("row_id"));
                        int j = Convert.ToInt32(data_reader.GetString("column_id"));
                        MetroTileA[i, j].Style = MetroColorStyle.Green;
                    }
                }
                TableLayOut.Refresh();
                data_reader.Close();
                string deleteStatement = "delete from cargoList where warehouse_id = \"" + cargo_name + "\" and " + "cargo_id = \"" + text + "\"";
                com = new MySqlCommand(deleteStatement, Login.con);
                com.ExecuteNonQuery();
                string insertStatement = "insert into finishlist values(\"" + worker_id + "\",\"" + text + "\",localtimestamp())";
                com = new MySqlCommand(insertStatement, Login.con);
                com.ExecuteNonQuery();
                CargoComboBox.Items.Remove(text);
            }
        }

        private void CargoComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string text = CargoComboBox.Text;
            Console.Write("test:" + text);
            UpdataTable(cargo_name);
            string selectStatement = "select * from cargoList where warehouse_id = \"" + cargo_name + "\" and " + "cargo_id = \"" + text + "\"";
            com = new MySqlCommand(selectStatement, Login.con);
            MySqlDataReader data_reader = com.ExecuteReader();
            if (data_reader.HasRows)
            {
                while (data_reader.Read())
                {
                    int i = Convert.ToInt32(data_reader.GetString("row_id"));
                    int j = Convert.ToInt32(data_reader.GetString("column_id"));
                    Console.WriteLine("i:" + i.ToString());
                    MetroTileA[i, j].Style = MetroColorStyle.Yellow;
                }
            }
            TableLayOut.Refresh();
            data_reader.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FillComboBox();
            UpdataTable(cargo_name);
            TableLayOut.Refresh();
        }
    }
}
