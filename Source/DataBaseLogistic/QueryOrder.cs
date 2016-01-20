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


namespace DataBaseLogistic
{
    public partial class QueryOrder : MetroForm
    {
        private static MySqlCommand com;
        private List<string> order_lists;
        private int current;
        public QueryOrder(List<string> _order_lists)
        {
            order_lists = _order_lists;
            InitializeComponent();
            UpdateTime(order_lists[0]);
            current = 0;
        }

        private void MyOrder_Click(object sender, EventArgs e)
        {

        }



        private void UpdateTime(string order_id)
        {
            string selectStatement = "select * from orderlist where " +
           "order_id = \"" + order_id + "\"";
            NumberLabel.Text = "订单编号：" + order_id;
            com = new MySqlCommand(selectStatement, Login.con);
            com.ExecuteNonQuery();
            MySqlDataReader dataReader = com.ExecuteReader();
            try
            {
                if (dataReader.HasRows && dataReader.Read() && dataReader.GetString("order_id") != null)
                {
                    string order_state = dataReader.GetString("state");
                    string latest_time = null;

                    switch (order_state)
                    {
                        case "placed":
                            DTrackBar.Value = 0;
                            BackOrderButton.Style = MetroColorStyle.Red;
                            BackOrderButton.Enabled = true;
                            latest_time = dataReader.GetString("placeOrder_time");
                            break;
                        case "checked":
                            DTrackBar.Value = 9;
                            BackOrderButton.Style = MetroColorStyle.Black;
                            BackOrderButton.Enabled = false;
                            latest_time = dataReader.GetString("checkOrder_time");
                            break;
                        case "received":
                            DTrackBar.Value = 19;
                            BackOrderButton.Style = MetroColorStyle.Black;
                            BackOrderButton.Enabled = false;
                            latest_time = dataReader.GetString("receiveCargo_time");
                            break;
                        case "entered":
                            DTrackBar.Value = 31;
                            BackOrderButton.Style = MetroColorStyle.Black;
                            BackOrderButton.Enabled = false;
                            latest_time = dataReader.GetString("enterWarehouse_time");
                            break;
                        case "dised":
                            DTrackBar.Value = 43;
                            BackOrderButton.Style = MetroColorStyle.Black;
                            BackOrderButton.Enabled = false;
                            latest_time = dataReader.GetString("distribute_time");
                            break;
                        case "finished":
                            DTrackBar.Value = 50;
                            BackOrderButton.Style = MetroColorStyle.Black;
                            BackOrderButton.Enabled = false;
                            latest_time = dataReader.GetString("finish_time");
                            break;
                        default: break;
                    }
                    UpdateTimeLabel.Text = "订单最近更新时间：" + latest_time;
                    BackOrderButton.Text = "撤销订单";
                    MoreInformLink.Enabled = true;
                    UpdateTimeLabel.Visible = true;
                }
                else
                {
                    BackOrderButton.Style = MetroColorStyle.Black;
                    BackOrderButton.Text = "撤销中";
                    BackOrderButton.Enabled = false;
                    MoreInformLink.Enabled = false;
                    UpdateTimeLabel.Visible = false;
                }
            }
           catch (System.Data.SqlTypes.SqlNullValueException)
           {
              MetroFramework.MetroMessageBox.Show(this, "该订单状态无效", "系统错误", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
           }
           finally
            {
                dataReader.Close();
           }
        }

        //next
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (current == order_lists.Count() - 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "客官，没有更多的订单了哟~", "订单", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                current = current + 1;
                UpdateTime(order_lists[current]);
            }
        }

        //previous
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (current == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "客官，没有更多的订单了哟~", "订单", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                current = current - 1;
                UpdateTime(order_lists[current]);
            }

        }

        private void MoreInformLink_Click(object sender, EventArgs e)
        {
            string selectStatement = "select * from orderlist where order_id = \"" + order_lists[current] + "\"";
            com = new MySqlCommand(selectStatement, Login.con);
            com.ExecuteNonQuery();
            MySqlDataReader dataReader = com.ExecuteReader();
            dataReader.Read();
            string _order_id = order_lists[current];
            string _receiver_id = dataReader.GetString("receiver_id");
            string _count = dataReader.GetString("money_amount");
            string _state = "";
            switch (dataReader.GetString("state"))
            {
                case "placed":
                    _state = "已经成功下单，等待确认中";
                    break;
                case "checked":
                    _state = "订单已经被确认，等待接收中";
                    break;
                case "received":
                    _state = "货物已经被接收，等待入库";
                    break;
                case "entered":
                    _state = "货物已经入库，等待配送员配送";
                    break;
                case "dised":
                    _state = "订单正在配送中";
                    break;
                case "finished":
                    _state = "已经成功送达到收货方";
                    break;
                default: break;
            }
            dataReader.Close();
            MorInform inform = new MorInform(_order_id, _receiver_id, _count, _state);
            inform.Show();
        }

        private void BackOrderButton_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "确认要撤销订单" + order_lists[current] + "吗？", "撤销确认", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)
                == DialogResult.Yes)
            {
                string selectStatement = "select state from orderlist where order_id = \"" + order_lists[current] + "\"";
                com = new MySqlCommand(selectStatement, Login.con);
                MySqlDataReader data_reader = com.ExecuteReader();
                data_reader.Read();
                if (data_reader.GetString("state") != "placed")
                {
                    MetroFramework.MetroMessageBox.Show(this, "接货员已经在路上啦~订单无法撤销了~", "订单无法撤销");
                    data_reader.Close();
                    UpdateTime(order_lists[current]);
                }
                else
                {
                    data_reader.Close();
                    string deleteStatement = "delete from orderlist where order_id = \"" + order_lists[current] + "\"";
                    com = new MySqlCommand(deleteStatement, Login.con);
                    com.ExecuteNonQuery();
                    BackOrderButton.Style = MetroColorStyle.Black;
                    BackOrderButton.Text = "撤销中";
                    BackOrderButton.Enabled = false;
                    MoreInformLink.Enabled = false;
                    UpdateTimeLabel.Visible = false;
                }
            }
        }
    }
}
