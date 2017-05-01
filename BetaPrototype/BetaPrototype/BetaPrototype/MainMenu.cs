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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeTransaction finance = new MakeTransaction();
            finance.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameCreation newgame = new GameCreation();
            newgame.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadingGames newsearch = new LoadingGames();
            newsearch.Show();
        }
    }
}
