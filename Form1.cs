using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Random rd = new();  //创建随机数对象

        DateTime TimeNow = new();
        TimeSpan TimeCount = new();

        //计数器
        int Counter = new();

        //单次游戏长度
        int Words = 30;

        readonly string[] record = new string[] {"0","0","0","0","0","0","0","0","0","0"};

        string[] listbts = new string[] {
                "bt0","bt1","bt2","bt3","bt4","bt5","bt6","bt7","bt8","bt9",
                "bt10","bt11","bt12","bt13","bt14","bt15","bt16","bt17","bt18","bt119","bt20",
                "ba","bb","bc","bd","be","bf","bg","bh","bi","bj","bk","bl",
                "bm","bn","bo","bp","bq","br","bs","bt","bu","bv","bw","bx","by","bz"
            };

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        public string Key4button(string key)
        {
            switch (key)
            {
                case "!" or "1":
                    return "b1".ToString();

                case "@" or "2":
                    return "b2".ToString();

                case "#" or "3":
                    return "b3".ToString();

                case "$" or "4":
                    return "b4".ToString();

                case "%" or "5":
                    return "b5".ToString();

                case "^" or "6":
                    return "b6".ToString();

                case "&" or "7":
                    return "b7".ToString();

                case "*" or "8":
                    return "b8".ToString();

                case "(" or "9":
                    return "b9".ToString();

                case ")" or "0":
                    return "b0".ToString();

                case "a" or "A":
                    return "ba".ToString();

                case "b" or "B":
                    return "bb".ToString();

                case "c" or "C":
                    return "bc".ToString();

                case "d" or "D":
                    return "bd".ToString();

                case "e" or "E":
                    return "be".ToString();

                case "f" or "F":
                    return "bf".ToString();

                case "g" or "G":
                    return "bg".ToString();

                case "h" or "H":
                    return "bh".ToString();

                case "i" or "I":
                    return "bi".ToString();

                case "j" or "J":
                    return "bj".ToString();

                case "k" or "K":
                    return "bk".ToString();

                case "l" or "L":
                    return "bl".ToString();

                case "m" or "M":
                    return "bm".ToString();

                case "n" or "N":
                    return "bn".ToString();

                case "o" or "O":
                    return "bo".ToString();

                case "p" or "P":
                    return "bp".ToString();

                case "q" or "Q":
                    return "bq".ToString();

                case "r" or "R":
                    return "br".ToString();

                case "s" or "S":
                    return "bs".ToString();

                case "t" or "T":
                    return "bt".ToString();

                case "u" or "U":
                    return "bu".ToString();

                case "v" or "V":
                    return "bv".ToString();

                case "w" or "W":
                    return "bw".ToString();

                case "x" or "X":
                    return "bx".ToString();

                case "y" or "Y":
                    return "by".ToString();

                case "z" or "Z":
                    return "bz".ToString();

                case "`" or "~":
                    return "b10".ToString();

                case "-" or "_":
                    return "b11".ToString();

                case "=" or "=":
                    return "b12".ToString();

                case "[" or "{":
                    return "b13".ToString();
                
                case "]" or "}":
                    return "b14".ToString();

                case ";" or ":":
                    return "b15".ToString();

                case "'" or "\"":
                    return "b16".ToString();

                case "," or "<":
                    return "b17".ToString();

                case "." or ">":
                    return "b18".ToString();

                case "/" or "?":
                    return "b19".ToString();

                case "\\" or "|":
                    return "b20".ToString();

                default:
                    return "space";
            };
           
        }

        public string Number4key(int key)
        {
            String [] keys = new string[]
            {
                " ", "\"", "!", "#", "$", "%", "&", "'","(",
                ")","*","+",",", "-", ".", "/", "0", "1", "2",
                "3","4", "5","6","7","8","9",":", ";", "<",
                "=", ">","?","@","A", "B", "C","D", "E", "F",
                "G","H", "I","J","K","L","M","N","O","P",
                "Q","R","S","T","U","V","W","X","Y","Z",
                "[", "\\", "]", "^", "_", "`",
                "a","b","c","d","e","f","g","h","i","j",
                "k","l","m","n","o", "p","q","r","s","t",
                "u","v","w","x","y","z","{","|","}","~"
            };

            return keys[key];
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Counter <= Words)
            {
                TimeCount = DateTime.Now - TimeNow;
                label1.Text = string.Format("{0:00}:{1:00}:{2:00}", TimeCount.Hours, TimeCount.Minutes, TimeCount.Seconds);

                string keyname = Key4button(e.KeyChar.ToString());
                //MessageBox.Show(e.KeyChar.ToString());

                Control control = this.Controls[keyname];

                Button redbutton = (Button)control;

                if (redbutton.BackColor == Color.Green)
                {
                    redbutton.BackColor = Color.Black;
                    //随机选取键盘按键
                    int rndcode = rd.Next(0, 94);
                    string rndkeyname = Key4button(Number4key(rndcode));

                    Control rndcontrol = this.Controls[rndkeyname];

                    Button rndbutton = (Button)rndcontrol;

                    rndbutton.BackColor = Color.Green;
                    rndbutton.Focus();


                    foreach (Control bts in this.Controls)
                    {
                        //遍历后的操作...
                        if (bts.Name != rndkeyname)
                        {
                            bts.BackColor = Color.Black;
                        }
                    }

                    Counter++;
                }
            }
            else
            {
                MessageBox.Show(string.Format("{0},{1}",textBox1.Text, TimeCount.Hours*60*60+TimeCount.Minutes*60+TimeCount.Seconds));
                //记录成绩
                for (int i = 0; i < record.Length; i++)
                {
                    if (record[i] == "0")
                    {
                        record[i] = (TimeCount.Hours * 60 * 60 + TimeCount.Minutes * 60 + TimeCount.Seconds).ToString();
                       
                        listBox1.Items.Add(record[i]+"(S) " + Words.ToString());

                        if (i <  record.Length-1)
                        {
                            break;
                        }
                        else
                        {
                            foreach (Control control in this.Controls)
                            {
                                //停止操作
                                control.Enabled = false;
                            }
                            //发送成绩到服务器

                        }  
                    } 
                }     
            }
        }

        //页面加载完成后
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                //修改控件字体和背景颜色
                control.BackColor = Color.Black;
                control.ForeColor = Color.White;
            }
            //MessageBox.Show(record[0]);
        }

        //开始按钮
        private void button6_Click(object sender, EventArgs e)
        {
            Counter = 0;
            timer1.Start();
            TimeNow = DateTime.Now;

            space.BackColor = Color.Green;
            space.Focus();
            textBox1.Enabled = false;
        }


        //重置按钮
        private void button7_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                //遍历后的操作...
                control.BackColor = Color.Black;
                control.ForeColor = Color.White;
            }

        }
    }
}
