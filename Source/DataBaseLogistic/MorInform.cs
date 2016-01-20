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

namespace DataBaseLogistic
{
    public partial class MorInform : MetroForm
    {
        public MorInform(string _order_id,string _receive_id,string _count,string _state)
        {
            InitializeComponent();
            OrderIdLabel.Text += _order_id;
            ReceiveIdLabel.Text += _receive_id;
            CountLabel.Text += _count;
            StateLabel.Text += _state;
        }
    }
}
