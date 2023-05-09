using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keymanx
{
    public partial class Form2_senior : Form
    {
        // 实例化随机类 - 随机 ASCII 键码
        private Random rd = new();

        // 实例化计时器 - 记录打字用时
        DateTime TimeNow = new();
        TimeSpan TimeCount = new();

        // 字数计数器和错字计数器
        int Counter = new();
        int CounterErr = new();

        // 单次打字所需字数
        int WordsTotal = 47;

        // 成绩记录列表，以及一局打字的总次数
        readonly List<int> ScoreRecordList = new List<int>() { 0, 0, 0, 0, 0, 0 };

        // 用于标记是否开始
        bool startFlag = false;

        string[] hideBtnKbs = new string[]
        {
            "btn_kb_0","btn_kb_1","btn_kb_2","btn_kb_3","btn_kb_4","btn_kb_5","btn_kb_6","btn_kb_7","btn_kb_8","btn_kb_9",
            "btn_kb_sb1","btn_kb_sb2","btn_kb_sb3","btn_kb_sb4","btn_kb_sb5","btn_kb_sb6","btn_kb_sb7","btn_kb_sb8","btn_kb_sb9","btn_kb_sb10","btn_kb_sb11",
            "btn_kb_a","btn_kb_b","btn_kb_c","btn_kb_d","btn_kb_e","btn_kb_g","btn_kb_h","btn_kb_i","btn_kb_k","btn_kb_l",
            "btn_kb_m","btn_kb_n","btn_kb_o","btn_kb_p","btn_kb_q","btn_kb_r","btn_kb_s","btn_kb_t","btn_kb_u","btn_kb_v","btn_kb_w","btn_kb_x","btn_kb_y","btn_kb_z"
        };

        UdpClient client = new UdpClient(8001);
        IPEndPoint remotePoint = new IPEndPoint(IPAddress.Parse("234.0.0.25"), 8002);

        public Form2_senior()
        {
            InitializeComponent();
            KeyPreview = true;

            client.JoinMulticastGroup(IPAddress.Parse("234.0.0.25"));
        }

        // 字母或数字转按钮控件
        public string key2btn(dynamic key)
        {
            // 如果参数为 int 类型则进行这一步过滤
            if (key.GetType() == typeof(int))
            {
                String[] keys = new string[]
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

                key = keys[key];
            }

            switch (key.ToString())
            {
                case "!" or "1":
                    key = "btn_kb_1";
                    break;
                case "@" or "2":
                    key = "btn_kb_2";
                    break;
                case "#" or "3":
                    key = "btn_kb_3";
                    break;
                case "$" or "4":
                    key = "btn_kb_4";
                    break;
                case "%" or "5":
                    key = "btn_kb_5";
                    break;
                case "^" or "6":
                    key = "btn_kb_6";
                    break;
                case "&" or "7":
                    key = "btn_kb_7";
                    break;
                case "*" or "8":
                    key = "btn_kb_8";
                    break;
                case "(" or "9":
                    key = "btn_kb_9";
                    break;
                case ")" or "0":
                    key = "btn_kb_0";
                    break;
                case "a" or "A":
                    key = "btn_kb_a";
                    break;
                case "b" or "B":
                    key = "btn_kb_b";
                    break;
                case "c" or "C":
                    key = "btn_kb_c";
                    break;
                case "d" or "D":
                    key = "btn_kb_d";
                    break;
                case "e" or "E":
                    key = "btn_kb_e";
                    break;
                case "f" or "F":
                    key = "btn_kb_f";
                    break;
                case "g" or "G":
                    key = "btn_kb_g";
                    break;
                case "h" or "H":
                    key = "btn_kb_h";
                    break;
                case "i" or "I":
                    key = "btn_kb_i";
                    break;
                case "j" or "J":
                    key = "btn_kb_j";
                    break;
                case "k" or "K":
                    key = "btn_kb_k";
                    break;
                case "l" or "L":
                    key = "btn_kb_l";
                    break;
                case "m" or "M":
                    key = "btn_kb_m";
                    break;
                case "n" or "N":
                    key = "btn_kb_n";
                    break;
                case "o" or "O":
                    key = "btn_kb_o";
                    break;
                case "p" or "P":
                    key = "btn_kb_p";
                    break;
                case "q" or "Q":
                    key = "btn_kb_q";
                    break;
                case "r" or "R":
                    key = "btn_kb_r";
                    break;
                case "s" or "S":
                    key = "btn_kb_s";
                    break;
                case "t" or "T":
                    key = "btn_kb_t";
                    break;
                case "u" or "U":
                    key = "btn_kb_u";
                    break;
                case "v" or "V":
                    key = "btn_kb_v";
                    break;
                case "w" or "W":
                    key = "btn_kb_w";
                    break;
                case "x" or "X":
                    key = "btn_kb_x";
                    break;
                case "y" or "Y":
                    key = "btn_kb_y";
                    break;
                case "z" or "Z":
                    key = "btn_kb_z";
                    break;
                case "`" or "~":
                    key = "btn_kb_sb1";
                    break;
                case "-" or "_":
                    key = "btn_kb_sb2";
                    break;
                case "=" or "=":
                    key = "btn_kb_sb3";
                    break;
                case "[" or "{":
                    key = "btn_kb_sb4";
                    break;
                case "]" or "}":
                    key = "btn_kb_sb5";
                    break;
                case ";" or ":":
                    key = "btn_kb_sb7";
                    break;
                case "'" or "\"":
                    key = "btn_kb_sb8";
                    break;
                case "," or "<":
                    key = "btn_kb_sb9";
                    break;
                case "." or ">":
                    key = "btn_kb_sb10";
                    break;
                case "/" or "?":
                    key = "btn_kb_sb11";
                    break;
                case "\\" or "|":
                    key = "btn_kb_sb6";
                    break;
                case "Oemtilde":
                    key = "btn_kb_sb1";
                    break;
                case "OemMinus":
                    key = "btn_kb_sb2";
                    break;
                case "Oemplus":
                    key = "btn_kb_sb3";
                    break;
                case "OemOpenBrackets":
                    key = "btn_kb_sb4";
                    break;
                case "Oem6":
                    key = "btn_kb_sb5";
                    break;
                case "Oem5":
                    key = "btn_kb_sb6";
                    break;
                case "Oem1":
                    key = "btn_kb_sb7";
                    break;
                case "Oem7":
                    key = "btn_kb_sb8";
                    break;
                case "Oemcomma":
                    key = "btn_kb_sb9";
                    break;
                case "OemPeriod":
                    key = "btn_kb_sb10";
                    break;
                case "OemQuestion":
                    key = "btn_kb_sb11";
                    break;
                case "D1":
                    key = "btn_kb_1";
                    break;
                case "D2":
                    key = "btn_kb_2";
                    break;
                case "D3":
                    key = "btn_kb_3";
                    break;
                case "D4":
                    key = "btn_kb_4";
                    break;
                case "D5":
                    key = "btn_kb_5";
                    break;
                case "D6":
                    key = "btn_kb_6";
                    break;
                case "D7":
                    key = "btn_kb_7";
                    break;
                case "D8":
                    key = "btn_kb_8";
                    break;
                case "D9":
                    key = "btn_kb_9";
                    break;
                case "D0":
                    key = "btn_kb_0";
                    break;
                default:
                    key = "btn_kb_space";
                    break;
            };

            return key.ToString();
        }

        // 开始
        public void start()
        {
            Counter = 0;
            CounterErr = 0;

            progressBar1.Value = 0;
            lb_ecrg_1.ForeColor = Color.FromArgb(10, 10, 10);
            lb_ecrg_2.ForeColor = Color.FromArgb(10, 10, 10);

            timer1.Start();
            TimeNow = DateTime.Now;

            btn_kb_space.BackColor = Color.Green;
            btn_kb_space.Focus();

            tb_class.Enabled = false;
            tb_name.Enabled = false;
            btn_start.Enabled = false;

            startFlag = true;
        }

        // 重置
        public void reset()
        {
            for (int i = 0; i < 95; i++)
            {
                Button btn = (Button)this.Controls[key2btn(i)];

                btn.BackColor = Color.FromArgb(10, 10, 10);
                btn.ForeColor = Color.FromArgb(10, 10, 10);
            }

            label_timing.Text = "00:00:00";

            foreach (Control control in this.Controls)
            {
                if (hideBtnKbs.Contains(control.Name))
                {
                    control.ForeColor = Color.FromArgb(10, 10, 10);
                }
            }

            btn_kb_f.ForeColor = Color.White;
            btn_kb_j.ForeColor = Color.White;

            startFlag = false;
            btn_start.Enabled = true;
        }

        // next
        public void nextone()
        {
            startFlag = false;

            foreach (Control con in this.Controls)
            {
                con.Enabled = true;
            }

            lb_scorelist.Items.Clear();
            tb_name.Enabled = true;
            tb_name.Text = "";
            tb_class.Enabled = true;
            tb_class.Text = "";
            tb_class.Focus();

            progressBar1.Value = 0;
            lb_ecrg_1.ForeColor = Color.FromArgb(10, 10, 10);
            lb_ecrg_2.ForeColor = Color.FromArgb(10, 10, 10);

            btn_kb_f.ForeColor = Color.White;
            btn_kb_j.ForeColor = Color.White;

            for (int i = 0; i < ScoreRecordList.Count; i++)
            {
                ScoreRecordList[i] = 0;
            }
        }

        // 发送成绩数据到组播地址中
        public void sendToMulticast(string sendString)
        {
            byte[] sendData = Encoding.Default.GetBytes(sendString);

            client.Send(sendData, sendData.Length, remotePoint);
        }

        private void Form2_senior_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!startFlag)
            {
                return;
            };

            // 计时并显示
            TimeCount = DateTime.Now - TimeNow;
            label_timing.Text = string.Format("{0:00}:{1:00}:{2:00}", TimeCount.Hours, TimeCount.Minutes, TimeCount.Seconds);

            // 获取当前按下按键，并判断是否正确
            {
                Control btnCon = this.Controls[key2btn(e.KeyChar)];
                Button btn = (Button)btnCon;

                if (btn.BackColor == Color.Green)
                {
                    if (e.KeyChar == 'f' || e.KeyChar == 'F' || e.KeyChar == 'j' || e.KeyChar == 'J')
                    {
                        btn.BackColor = Color.FromArgb(10, 10, 10);
                        btn.ForeColor = Color.White;
                    }
                    else
                    {
                        btn.BackColor = Color.FromArgb(10, 10, 10);
                        btn.ForeColor = Color.FromArgb(10, 10, 10);
                    }

                    int rdKeyNum = rd.Next(0, 95);

                    Control rdBtnCon = this.Controls[key2btn(rdKeyNum)];
                    Button rdBtn = (Button)rdBtnCon;

                    rdBtn.BackColor = Color.Green;
                    rdBtn.ForeColor = Color.Green;
                    rdBtn.Focus();

                    progressBar1.Value = (int)((float)Counter / WordsTotal * 100);

                    if (progressBar1.Value > 50)
                    {
                        lb_ecrg_1.ForeColor = Color.White;
                    }

                    if (progressBar1.Value > 70)
                    {
                        lb_ecrg_1.ForeColor = Color.FromArgb(8, 8, 8);
                        lb_ecrg_2.ForeColor = Color.White;
                    }

                    Counter++;
                }
                else
                {
                    CounterErr++;
                }
            }

            // 满足单次打字要求的字数时
            if (Counter - 1 == WordsTotal)
            {
                for (int i = 0; i < 95; i++)
                {
                    Button btn = (Button)this.Controls[key2btn(i)];

                    btn.BackColor = Color.FromArgb(10, 10, 10);
                    btn.ForeColor = Color.FromArgb(10, 10, 10);
                }

                btn_kb_space.Focus();

                int score = CounterErr + TimeCount.Hours * 60 * 60 + TimeCount.Minutes * 60 + TimeCount.Seconds;

                MessageBox.Show(string.Format("本轮计时共{0}秒，打错{1}个字\n本轮成绩: {0} + {1} = {2}", score - CounterErr, CounterErr, score));

                if (ScoreRecordList[0] == 0)
                {
                    // 成绩增加到列表
                    ScoreRecordList[0] = score;
                    ScoreRecordList.Sort();

                    // 清除列表控件旧数据
                    lb_scorelist.Items.Clear();

                    // 显示新成绩数据到列表控件
                    foreach (int x in ScoreRecordList)
                    {
                        if (x != 0)
                        {
                            lb_scorelist.Items.Add(x + "秒");
                        }
                    }

                    // 满足一局打字的总次数时
                    if (ScoreRecordList[0] != 0)
                    {
                        foreach (Control con in this.Controls)
                        {
                            con.Enabled = false;
                        }

                        sendToMulticast(tb_class.Text + " " + tb_name.Text + "#" + ScoreRecordList[0] + "#senior");

                        MessageBox.Show(string.Format("比赛结束！\n\n参赛选手：{0}\n选手班级：{1}\n\n您的最优成绩为 {2}", tb_name.Text, tb_class.Text, lb_scorelist.Items[0]), "比赛结束！");

                        nextone();
                    }
                    else
                    {
                        MessageBox.Show("点击下方“确定”或空格键，即可直接开始下一局打字");

                        // 不满足一局打字所需的总次数时，自动继续
                        reset();
                        start();
                    }
                }
            }
        }

        private void Form2_senior_KeyDown(object sender, KeyEventArgs e)
        {
            if (!startFlag)
            {
                return;
            };

            int key = e.KeyValue;

            if (!((key >= 65 && key <= 90) || (key >= 48 && key <= 57) || (key >= 186 && key <= 222) || key == 32))
            {
                return;
            }

            Control btnCon = this.Controls[key2btn(e.KeyCode)];
            Button btn = (Button)btnCon;

            if (btn.BackColor != Color.Green)
            {
                btn.BackColor = Color.Red;
                btn.ForeColor = Color.Red;
            }
        }

        private void Form2_senior_KeyUp(object sender, KeyEventArgs e)
        {
            if (!startFlag)
            {
                return;
            };

            int key = e.KeyValue;

            if (!((key >= 65 && key <= 90) || (key >= 48 && key <= 57) || (key >= 186 && key <= 222) || key == 32))
            {
                return;
            }

            Control btnCon = this.Controls[key2btn(e.KeyCode)];
            Button btn = (Button)btnCon;

            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = Color.FromArgb(10, 10, 10);
                btn.ForeColor = Color.FromArgb(10, 10, 10);
            }

            btn_kb_f.ForeColor = Color.White;
            btn_kb_j.ForeColor = Color.White;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (tb_class.Text == "" || tb_name.Text == "")
            {
                MessageBox.Show("请输入您的班级和姓名");
            }
            else
            {
                start();
            }
        }

        private void Form2_senior_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void Form2_senior_Activated(object sender, EventArgs e)
        {
            tb_class.Focus();
        }

        private void Form2_senior_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
