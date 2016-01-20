using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;
using MetroFramework;
using System.Threading;

namespace DataBaseLogistic
{
    public partial class Login : MetroForm
    {
        public static MySqlConnection con;
        private static MySqlCommand com;

        public Login()
        {
            InitializeComponent();
            con = new MySqlConnection("server = localhost;userid = root;password = 123456;database = log;");
            con.Open();
            MetroFramework.MetroMessageBox.Show(this, "数据库连接成功！", "连接请求");
            InitialTable();
        }

        private void InitialTable()
        {

            com = Create.createReceivList(con);
            com.ExecuteNonQuery();

            com = Create.createCheckList(con);
            com.ExecuteNonQuery();

            com = Create.createEnterList(con);
            com.ExecuteNonQuery();

            com = Create.createDistributeList(con);
            com.ExecuteNonQuery();

            com = Create.createPlaceOrderList(con);
            com.ExecuteNonQuery();

            com = Create.createClient(con);
            com.ExecuteNonQuery();

            com = Create.createWorker(con);
            com.ExecuteNonQuery();

            com = Create.createCargo(con);
            com.ExecuteNonQuery();

            com = Create.createOrder(con);
            com.ExecuteNonQuery();

            com = Create.createWarehouse(con);
            com.ExecuteNonQuery();

            com = Create.createAdmin(con);
            com.ExecuteNonQuery();

            com = Create.createCargoList(con);
            com.ExecuteNonQuery();

            com = Create.createFinishList(con);
            com.ExecuteNonQuery();

            //创建触发器
            
            //com = Create.TrigCheck(con);
            //com.ExecuteNonQuery();
            

            //com = Create.TrigReceiv(con);
            //com.ExecuteNonQuery();
            

            //com = Create.TrigEnter(con);
            //com.ExecuteNonQuery();
            

            //com = Create.TrigDistribute(con);
            //com.ExecuteNonQuery();
            

            //com = Create.TrigFinish(con);
            //com.ExecuteNonQuery();
            
            //添加存储过程
            /*
            com = Create.ProcAddMoney(con);
            com.ExecuteNonQuery();

            com = Create.ProcChangeState(con);
            com.ExecuteNonQuery();
            
            com = Create.ProcChangeAddr(con);
            com.ExecuteNonQuery();
            

            com = Create.ProcChangePhone(con);
            com.ExecuteNonQuery();
            
            
            com = Create.ProcChangeEmail(con);
            com.ExecuteNonQuery();
            */
        }

        private void RegisterLink_Click(object sender, EventArgs e)//登录面板弹出
        {
            Register register = new Register();
            register.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)//点击登录按钮后发生的动作
        {
            string userId = textBox2.Text;
            string userPwd = textBox1.Text;
            string selectStatement = "select * from worker where " +
                "worker_id = \"" + userId + "\" " + "and worker_pwd = \"" +
                userPwd + "\" and not exists ( select * from client where user_id = \"" + userId + "\" " + " and user_pwd = \"" + userPwd +"\")";
            com = new MySqlCommand(selectStatement, con);
            com.ExecuteNonQuery();
            MySqlDataReader dataReader = com.ExecuteReader();
            if (!dataReader.HasRows)
            {
                com = new MySqlCommand("select * from client where user_id = \"" + userId + "\" " + " and user_pwd = \"" + userPwd + "\"", con);
                dataReader.Close();
                com.ExecuteNonQuery();
                dataReader = com.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    User user = new User(dataReader, con,this);
                    user.Show();
                    this.Visible = false;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "用户名或密码错误", "登录失败");
                    dataReader.Close();
                }
            }
            else if (dataReader.HasRows)
            {
                dataReader.Read();
                if (dataReader.GetString("worker_occupt") == "warehouser")
                {
                    WareHouseManager ware_houser = new WareHouseManager(dataReader,this);
                    ware_houser.Show();
                    this.Visible = false;
                }
                else if(dataReader.GetString("worker_occupt") == "deliver")
                {
                    DeliverManager deliver = new DeliverManager(dataReader,this);
                    deliver.Show();
                    this.Visible = false;
                }
                else if(dataReader.GetString("worker_occupt") == "receiver")
                {
                    ReceiveManager receiver = new ReceiveManager(dataReader,this);
                    receiver.Show();
                    this.Visible = false;
                }
                else if(dataReader.GetString("worker_occupt") == "adminer")
                {
                    dataReader.Close();
                    Admin adminer = new Admin(this);
                    adminer.Show();
                    this.Visible = false;
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "用户名或密码错误", "登录失败");
            }
        }

        public MySqlCommand c { get; set; }
    }
}
