using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassFn;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void displayRankList(string level, object control)
        {
            dynamic rankListObj = new ClassFn.Http.Get("http://38.34.244.41:8001/api/data/ranklist?level=" + level).getData();
            dynamic rankList = rankListObj.data;

            for (int i = 0; i < rankList.Count; i++)
            {
                string listText = string.Format("{0} \t{1}(S)", rankList[i].name, rankList[i].score);
                (control as ListBox).Items.Add(listText);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            displayRankList("初级", listBox1);
            displayRankList("高级", listBox2);
        }
    }
}
