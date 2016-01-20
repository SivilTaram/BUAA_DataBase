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
using MetroFramework.Controls;
using MySql.Data.MySqlClient;


namespace DataBaseLogistic
{
    public partial class WareHouse : MetroForm
    {
        private MetroTile[,] MetroTileA = new MetroTile[10,20];
        private static MySqlCommand com;
        private string cargo_num;
        private string cargo_name;
        private string warehouser_name;

        public WareHouse(string _cargo_name,string _cargo_num,string _warehouser_name)
        {
            InitializeComponent();
            CargoNameLabel.Text = _cargo_name + "仓库";
            cargo_num = _cargo_num;
            cargo_name = _cargo_name;
            warehouser_name = _warehouser_name;
            InitialTable();
            UpdataTable(_cargo_name);
        }

        public void InitialTable()
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    MetroTileA[i, j] = new MetroTile();
                    MetroTile temp = MetroTileA[i, j];
                    temp.ActiveControl = null;
                    temp.Size = new System.Drawing.Size(20, 20);
                    temp.TabIndex = i*10+j;
                    temp.Tag = new int[] { i, j };
                    temp.Cursor = System.Windows.Forms.Cursors.Hand;
                    temp.Style = MetroFramework.MetroColorStyle.Green;
                    temp.Click += new System.EventHandler(this.MetroTile_Click);
                    temp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MetroTile_MouseDown);
                    TableLayout.Controls.Add(temp);
                }
            }
        }

        public void UpdataTable(string _cargo_name)
        {
            string selectStatement = "select * from cargolist where warehouse_id = \"" + _cargo_name + "\"";
            com = new MySqlCommand(selectStatement, Login.con);
            com.ExecuteNonQuery();
            MySqlDataReader dataReader = com.ExecuteReader();
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 20; j++)
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
                    MetroTileA[i, j].Enabled = false;
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

        public void MetroTile_MouseDown(object sender, MouseEventArgs e)
        {
            MetroTile click_metrotile = (MetroTile)sender;
            click_metrotile.Style =  click_metrotile.Style == MetroColorStyle.Green ? MetroColorStyle.Orange:
                                     click_metrotile.Style == MetroColorStyle.Red   ? MetroColorStyle.Red: 
                                     MetroColorStyle.Green;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            bool insert_success = false;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (MetroTileA[i, j].Style == MetroColorStyle.Orange)
                    {
                        insert_success = true;
                        string selectStatement = "insert into cargoList (warehouse_id,cargo_id,row_id,column_id) values(" + 
                            cargo_name + "," + cargo_num + "," + i.ToString() + "," + j.ToString() + ")";
                        com = new MySqlCommand(selectStatement, Login.con);
                        com.ExecuteNonQuery();
                        MetroTileA[i, j].Style = MetroColorStyle.Red;
                        MetroTileA[i, j].Enabled = false;
                    }
                }
            }
            if (insert_success)
            {
                MetroFramework.MetroMessageBox.Show(this, "已经成功将该货物信息添加至选定位置！", "入库成功");
                this.Close();
                string insertStatement = "insert into enterlist values(\"" + warehouser_name + "\",\"" + cargo_num + "\",localtimestamp())";
                com = new MySqlCommand(insertStatement, Login.con);
                com.ExecuteNonQuery();
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "没有选中任何位置！", "入库出错", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
