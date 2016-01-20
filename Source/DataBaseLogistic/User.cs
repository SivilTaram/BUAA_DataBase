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
using System.Threading;
using System.Text.RegularExpressions;

namespace DataBaseLogistic
{
    public partial class User : MetroForm
    {
        string name;
        string id;//账号
        string pwd;
        string email;
        string address;
        string idNum;//身份证号
        string phone;
        string crash;//金额
        string userId;
        private List<string> order_lists;
        MySqlConnection con;
        private MetroForm login;
        public User(MySqlDataReader dataReader,MySqlConnection con,MetroForm _login)
        {
            InitializeComponent();
            this.userId = dataReader.GetString(0);
            this.WelcomeNameLabel.Text += dataReader.GetString(2) + "!";
            nameDispalyText.Text = dataReader.GetString(2);
            emailDisplayText.Text = dataReader.GetString(3);
            addressDispalyText.Text = dataReader.GetString(5);
            phoneDisplayText.Text = dataReader.GetString(6);
            idNumDispalyText.Text = dataReader.GetString(4);
            moneyDispalyText.Text = dataReader.GetString(7);
            dataReader.Close();
            this.con = con;
            login = _login;
            this.FormClosing += User_FormClosing1;
        }

        private void User_FormClosing1(object sender, FormClosingEventArgs e)
        {
            login.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)//新订单管理button
        {
            Orders order = new Orders(userId);
            order.ShowDialog();
            if(order.DialogResult == DialogResult.OK)
            {
                double a = Convert.ToDouble(moneyDispalyText.Text);
                moneyDispalyText.Text = (a - 10).ToString(); 
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void addressDispalyText_Click(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)//查询订单操作
        {
            string selectStatement = "select * from orderlist where " +
                "user_id = \"" + userId + "\"";
            MySqlCommand com = new MySqlCommand(selectStatement, Login.con);
            com.ExecuteNonQuery();
            MySqlDataReader dataReader = com.ExecuteReader();
            //many.
            order_lists = null;
            if (dataReader.HasRows)
            {
                while (dataReader.Read() && dataReader.GetString(0) != null)
                {
                    if (order_lists == null)
                    {
                        order_lists = new List<string>();
                    }
                    // order_id
                    order_lists.Add(dataReader.GetString(0));
                }
            }
            dataReader.Close();
            if (order_lists == null || order_lists.Count==0 )
                MetroFramework.MetroMessageBox.Show(this, "您当前还没有下过单哦！", "订单", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                QueryOrder order = new QueryOrder(order_lists);
                order.Show();
            }
        }

        private void addMoneyButton_Click(object sender, EventArgs e)//充值
        {
            Regex regex = new Regex("(\\d+)");
            if(!regex.IsMatch(crashText.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "请输入正确的金额数据！", "格式错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            string updateStatement =
                "call addMoney(\"" + userId + "\", \"" + crashText.Text + "\")";
            MySqlCommand com = new MySqlCommand(updateStatement, con);
            com.ExecuteNonQuery();
            string selectStatement = "select * from client where " +
                "user_id = \"" + userId + "\" ";
            com = new MySqlCommand(selectStatement, con);
            com.ExecuteNonQuery();
            MySqlDataReader dataReader = com.ExecuteReader();
            dataReader.Read();
            moneyDispalyText.Text = dataReader.GetString(7);
            dataReader.Close();
            crashText.Text = "";

        }

        private void changeAddrButton_Click(object sender, EventArgs e)//修改地址
        {
            string updateStatement =
                "call changeAddr(\"" + userId + "\", \"" + addrText.Text + "\")";
            MySqlCommand com = new MySqlCommand(updateStatement, con);
            com.ExecuteNonQuery();
            string selectStatement = "select * from client where " +
                "user_id = \"" + userId + "\" ";
            com = new MySqlCommand(selectStatement, con);
            com.ExecuteNonQuery();
            MySqlDataReader dataReader = com.ExecuteReader();
            dataReader.Read();
            addressDispalyText.Text = dataReader.GetString(5);
            dataReader.Close();
            addrText.Text = "";
        }

        private void changePhoneButton_Click(object sender, EventArgs e)
        {
            string updateStatement =
                "call changePhone(\"" + userId + "\", \"" + phoneText.Text + "\")";
            MySqlCommand com = new MySqlCommand(updateStatement, con);
            com.ExecuteNonQuery();
            string selectStatement = "select * from client where " +
                "user_id = \"" + userId + "\" ";
            com = new MySqlCommand(selectStatement, con);
            com.ExecuteNonQuery();
            MySqlDataReader dataReader = com.ExecuteReader();
            dataReader.Read();
            phoneDisplayText.Text = dataReader.GetString(6);
            dataReader.Close();
            phoneText.Text = "";
        }

        private void changeMailButton_Click(object sender, EventArgs e)
        {
            string updateStatement =
                "call changeEmail(\"" + userId + "\", \"" + mailText.Text + "\")";
            MySqlCommand com = new MySqlCommand(updateStatement, con);
            com.ExecuteNonQuery();
            string selectStatement = "select * from client where " +
                "user_id = \"" + userId + "\" ";
            com = new MySqlCommand(selectStatement, con);
            com.ExecuteNonQuery();
            MySqlDataReader dataReader = com.ExecuteReader();
            dataReader.Read();
            emailDisplayText.Text = dataReader.GetString(3);
            dataReader.Close();
            mailText.Text = "";
        }

        private void UserInformTab_Click(object sender, EventArgs e)
        {

        }

        private void User_Leave(object sender, EventArgs e)
        {
        }

        private void changePwdButton_Click(object sender, EventArgs e)
        {
            string updateStatement = "update client set user_pwd = \""+currnentPwd.Text+"\" where user_id = \""+userId+"\"";
            MySqlCommand com = new MySqlCommand(updateStatement, Login.con);
            com.ExecuteNonQuery();
            currnentPwd.Text = "";
        }
    }
}
