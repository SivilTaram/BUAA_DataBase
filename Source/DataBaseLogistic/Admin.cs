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

namespace DataBaseLogistic
{
    public partial class Admin : MetroForm
    {
        private MetroForm login;
        public Admin(MetroForm _login)
        {
            InitializeComponent();
            login = _login;
            this.FormClosing += Admin_FormClosing;
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            string selectStatement = 
                "select * from client where user_id = \"" + clientManage.Text + 
                "\"";
            MySqlCommand com = new MySqlCommand(selectStatement, Login.con);
            MySqlDataReader dataReader = com.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                nameDispalyText.Text = dataReader.GetString(2);
                emailDisplayText.Text = dataReader.GetString(3);
                idNumDispalyText.Text = dataReader.GetString(4);
                addressDispalyText.Text = dataReader.GetString(5);
                phoneDisplayText.Text = dataReader.GetString(6);
                mountText.Text = dataReader.GetString(7);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "找不到您要查询的人！", "查询异常");
            }
            dataReader.Close();
        }

        private void workerButton_Click(object sender, EventArgs e)
        {
            string selectStatement =
                "select * from worker where worker_id = \"" + workerManage.Text +
                "\"";
            MySqlCommand com = new MySqlCommand(selectStatement,Login.con);
            MySqlDataReader dataReader = com.ExecuteReader();
            if (dataReader!=null && dataReader.HasRows && dataReader.Read())
            {
                if (!dataReader.IsDBNull(2))
                    workerNameText.Text = dataReader.GetString(2);
                else
                    workerNameText.Text = "";

                if (!dataReader.IsDBNull(7))
                    workerPhoneText.Text = dataReader.GetString(7);
                else
                    workerPhoneText.Text = "";

                if (!dataReader.IsDBNull(6))
                    workerOccupText.Text = dataReader.GetString(6);
                else
                    workerOccupText.Text = "";

                if (!dataReader.IsDBNull(5))
                    genderText.Text = dataReader.GetString(5);
                else
                    genderText.Text = "";

                if (!dataReader.IsDBNull(4))
                    nativeText.Text = dataReader.GetString(4);
                else
                    nativeText.Text = "";

                if (!dataReader.IsDBNull(8))
                    admitText.Text = dataReader.GetDateTime(8).ToShortDateString();
                else
                    admitText.Text = "";

                if (!dataReader.IsDBNull(3))
                    workerbirthText.Text = dataReader.GetDateTime(3).ToShortDateString();
                else
                    workerbirthText.Text = "";

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "对不起，查无此人！", "无编号");
            }
            dataReader.Close();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            string selectStatement =
                "select * from orderlist where order_id = \"" + orderListManage.Text +
                "\"";
            MySqlCommand com = new MySqlCommand(selectStatement, Login.con);
            MySqlDataReader dataReader = com.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                switch (dataReader.GetString(11))
                {
                    case "finished":stateText.Text = "已经完成";break;
                    case "checked":stateText.Text = "已经确认";break;
                    case "received":stateText.Text = "已经接货";break;
                    case "entered": stateText.Text = "已经入库";break;
                    case "distributed": stateText.Text = "已经送达"; break;
                    case "placed":stateText.Text = "已经成功下单";break;
                    default:break;
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "找不到您要查询的订单！", "查询出错");
                stateText.Text = "";
            }
            dataReader.Close();
        }

        private void addworker_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            worker.Show();
        }
    }
}
