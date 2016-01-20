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
using System.Text.RegularExpressions;

namespace DataBaseLogistic
{
    public partial class Orders : MetroForm
    {
        string cargoType;
        string cargoVolume;
        string cargoWeight;
        string cargoName;
        string receiverId;
        string userId;

        public Orders(string userId)
        {
            this.userId = userId;
            InitializeComponent();
            moneyLabel.Visible = false;
        }


        private void Orders_Load(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //根据用户所填写的订单设置所有的字段
            cargoType = cargoTypeText.Text;
            cargoName = nameText.Text;
            cargoVolume = volumeText.Text;
            cargoWeight = weightText.Text;
            receiverId = receiverText.Text;

            MySqlCommand com = new MySqlCommand("select user_account from client where user_id = \""+userId+"\"", Login.con);
            MySqlDataReader dataReader = com.ExecuteReader();
            dataReader.Read();
            float mount = dataReader.GetFloat(0);
            Console.Write(mount);
            dataReader.Close();
            if (mount < 10)
            {
                MetroFramework.MetroMessageBox.Show(this, "金额不够辣，快去充钱吧~", "金额不够");
                return;
            }
            com = new MySqlCommand("update client set user_account ="+(mount-10).ToString(),Login.con);
            com.ExecuteNonQuery();
            //计算货物编号
            com = new MySqlCommand("select count(*) from cargo", Login.con);
            com.ExecuteNonQuery();
            dataReader = com.ExecuteReader();
            dataReader.Read();
            Decimal cargoId = dataReader.GetDecimal(0);
            dataReader.Close();

            Regex regex = new Regex("(\\d+)");

            if(!regex.IsMatch(cargoVolume) || !regex.IsMatch(cargoWeight) || cargoType=="" || cargoName == "" || receiverId=="")
            {
                MetroFramework.MetroMessageBox.Show(this, "有些地方好像没写对哦，新建订单失败辣", "新建订单",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            //开始插入货物
            string insertStatement = " insert into cargo (" +
                "cargo_id,cargo_name,cargo_type,cargo_volume," +
                "cargo_weight ) " +
                "values ( \"" + cargoId.ToString() + "\", \"" + cargoName + "\", \"" +
                cargoType + "\", \"" + cargoVolume + "\", \"" + cargoWeight + "\" )";
            com = new MySqlCommand(insertStatement,Login.con);
            com.ExecuteNonQuery();

            //计算订单编号
            com = new MySqlCommand("select count(*) from orderlist", Login.con);
            com.ExecuteNonQuery();
            dataReader = com.ExecuteReader();
            dataReader.Read();
            Decimal orderId = dataReader.GetDecimal(0);
            dataReader.Close();

            //开始插入订单信息
            insertStatement = " insert into orderList (" +
                "order_id,cargo_id,user_id,receiver_id,money_amount,placeOrder_time," +
                "checkOrder_time,receiveCargo_time,enterWarehouse_time,distribute_time," + 
                "finish_time,state)" +
                "values (\"" + orderId.ToString() + "\", \"" + cargoId.ToString()
                + "\", \"" + userId + "\", \"" + receiverId + "\", " + "10" + 
                ", " + "localtimestamp()" + ",NULL" + ",NULL" + ",NULL" +　",NULL" + ",NULL" +
                ",\"placed\""  + ")";
            com = new MySqlCommand(insertStatement,Login.con);
            com.ExecuteNonQuery();
            
            //金额数显示
            moneyLabel.Text = "10";
            moneyLabel.Visible = true;
            MetroFramework.MetroMessageBox.Show(this, "下单成功！", "订单");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
