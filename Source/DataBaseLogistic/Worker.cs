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
    public partial class Worker : MetroForm
    {
        MySqlConnection con;
        public Worker()
        {
            InitializeComponent();
        }

        private void Worker_Load(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (nameText.Text != "" && nativeText.Text != "" && pwdText.Text != "" &&
               (occupText.Text == "receiver" ||
               occupText.Text == "deliver" ||
               occupText.Text == "adminer" ||
               occupText.Text == "warehourser"
                ) && phoneText.Text != ""
                &&
                (genderText.Text == "M" || genderText.Text == "F")
                )
            {
                MySqlCommand com = new MySqlCommand("select count(*) from worker", Login.con);
                com.ExecuteNonQuery();
                MySqlDataReader dataReader = com.ExecuteReader();
                dataReader.Read();
                Decimal workerId = dataReader.GetDecimal(0);
                dataReader.Close();
                string insertStatement =
                    "insert into worker values(\"" + workerId.ToString() + "\", \"" +
                    pwdText.Text + "\", \"" + nameText.Text + "\", \"" + birthText.Value + "\",\"" +
                    nativeText.Text + "\",\"" + genderText.Text + "\",\"" + occupText.Text + "\",\"" +
                    phoneText.Text + "\",\"" + adminText.Value + "\")";
                com = new MySqlCommand(insertStatement, Login.con);
                com.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(this, "新建员工的编号为 " + workerId.ToString(), "插入员工成功");
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "选项填写不完整，请填写完整！", "注册失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
