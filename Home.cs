using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keymanx
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_toForm1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1_primary().Show();
        }

        private void btn_toForm2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2_senior().Show();
        }

        private void btn_toForm3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3_profession().Show();
        }

        private void btn_toForm4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4_scoreboard().Show();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
