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
    public partial class Register : MetroForm
    {
        bool name_is_success = false;
        bool user_is_success = false;
        bool pwd_is_success = false;
        bool mail_is_success = false;
        bool id_is_success = false;
        bool addr_is_success = false;

        public string user_account;
        public string user_name;
        public string user_password;
        public string user_mail;
        public string user_id;
        public string user_address;
        public string user_phone;

        public Register()
        {
            InitializeComponent();
        }

        private void UserTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void UserTextBox_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {

        }

        private void NameTextBox_Click(object sender, EventArgs e)
        {

        }

        private void MailTextBox_Click(object sender, EventArgs e)
        {

        }

        private void IdTextBox_Click(object sender, EventArgs e)
        {

        }

        private void PhoneTextBox_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e) //insert the information of a user
        {

            user_account = UserTextBox.Text;
            user_name = NameTextBox.Text;
            user_password = PasswordTextBox.Text;
            user_mail = MailTextBox.Text;
            user_id = IdTextBox.Text;
            user_address = metroComboBox1.Text + metroComboBox2.Text;
            user_phone = PhoneTextBox.Text;

            string selectStatement;
            MySqlCommand com;
            MySqlDataReader dataReader;
            //验证用户名是否符合规范
            if (user_account.Length <= 20 && user_account.Length >= 3)
            {
                UserErrorLabel.Visible = false;
                user_is_success = true;
            }
            else
                UserErrorLabel.Visible = true;

            //验证是否密码长度合格6-20之间
            if (user_password.Length >= 6 && user_password.Length <= 20)
            {
                pwd_is_success = true;
                PasswordErrorLabel.Visible = false;
            }
            else
                PasswordErrorLabel.Visible = true;

            //验证邮箱的格式是否符合规则
            if (user_mail.Contains("@") == true)
            {
                mail_is_success = true;
                MailErrorLabel.Visible = false;
            }
            else
                MailErrorLabel.Visible = true;

            selectStatement = "select count(*) from client where user_id = \"" + user_account + "\"";
            com = new MySqlCommand(selectStatement, Login.con);
            com.ExecuteNonQuery();
            dataReader = com.ExecuteReader();
            dataReader.Read();
            if (dataReader.GetDecimal(0) != 0)
            {
                idConflictLabel.Visible = true;
                id_is_success = false;
            }
            else
            {
                idConflictLabel.Visible = false;
                id_is_success = true;
            }
            dataReader.Close();

            if (id_is_success && user_is_success && pwd_is_success && mail_is_success)
            {
                string insertStatement = " insert into client (" +
                "user_id,user_pwd,user_name,user_email," +
                "user_idNum,user_addr,user_phone,user_account ) " +
                "values ( \"" + user_account + "\", \"" + user_password + "\", \"" +
                user_name + "\", \"" + user_mail + "\", \"" + user_id + "\", \"" +
                user_address + "\", \"" + user_phone + "\", " + "0" + " )";

                //验证是否有用户名冲突的情况
                com = new MySqlCommand(insertStatement, Login.con);
                com.ExecuteNonQuery();
                if (MetroFramework.MetroMessageBox.Show(this, "您已成功注册，快来登录体验一下吧", "注册", MessageBoxButtons.OKCancel)
== DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "注册格式错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
