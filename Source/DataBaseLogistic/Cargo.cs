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
using MySql.Data.MySqlClient;

namespace DataBaseLogistic
{
    public partial class Cargo : MetroForm
    {
        private static MySqlCommand com;
        private string order_id;
        private string worker_id;
        private MySqlDataReader dataReader;
        private WareHouse cargo_house;

        public Cargo(string _order_id,string _worker_id,MySqlDataReader _dataReader)
        {
            InitializeComponent();
            order_id = _order_id;
            worker_id = _worker_id;
            dataReader = _dataReader;
            InitialInform();
            dataReader.Close();
            cargo_house = new WareHouse("233", order_id, worker_id);
        }

        public void InitialInform()
        {
             NameTextBox.Text = dataReader.GetString("cargo_name");
             TypeTextBox.Text = dataReader.GetString("cargo_type");
             WeightTextBox.Text = dataReader.GetString("cargo_weight");
             VolumeTextBox.Text = dataReader.GetString("cargo_volume");
        }


        private void YesButton_Click(object sender, EventArgs e)
        {
            cargo_house.ShowDialog();
            if (cargo_house.DialogResult == DialogResult.Yes)
                this.DialogResult = DialogResult.Yes;
            else
                this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.No;
        }
    }
}
