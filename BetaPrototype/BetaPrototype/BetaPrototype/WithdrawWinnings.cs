using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaPrototype
{
    public partial class WithdrawWinnings : Form
    {
        public WithdrawWinnings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transaction successful!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
