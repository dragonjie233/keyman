using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FnClass.Http;

namespace keymanx
{
    public partial class Form3_profession : Form
    {
        // 实例化计时器 - 记录打字用时
        DateTime TimeNow = new();
        TimeSpan TimeCount = new();

        // 用于标记是否开始
        bool startFlag = false;

        dynamic words_list;

        public Form3_profession()
        {
            InitializeComponent();
            KeyPreview = true;
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
                default:
                    key = "btn_kb_space";
                    break;
            };

            return key.ToString();
        }

        // 开始
        public void start()
        {
            timer1.Start();
            TimeNow = DateTime.Now;

            tb_class.Enabled = false;
            tb_name.Enabled = false;

            tb_procn.Focus();
            tb_procn.Text = "";

            string long_words = words_list[0].long_words;
            string trans_cn = words_list[0].trans_cn;

            label_proen.Text = long_words;
            label_pro2cn.Text = trans_cn;

            lb_wordlist.Items.RemoveAt(0);
            words_list.RemoveAt(0);

            startFlag = true;
        }

        // 重置
        public void reset()
        {
            for (int i = 0; i < 95; i++)
            {
                Button btn = (Button)this.Controls[key2btn(i)];

                btn.BackColor = SystemColors.Control;
                btn.UseVisualStyleBackColor = true;
                btn.ForeColor = SystemColors.ControlText;
            }

            label_timing.Text = "00:00:00";

            startFlag = false;
        }

        // 联网获取词库
        public void getWords()
        {
            dynamic reqList = new Get("http://38.34.244.41:8001/api/proenwords/?limit=20").getData();

            if (reqList is bool)
            {
                MessageBox.Show("因网络问题，无法连接服务器加载词库！\n请检查您是否联网。");
                System.Environment.Exit(0);
            }

            words_list = reqList.data;

            foreach (dynamic x in reqList.data)
            {
                lb_wordlist.Items.Add(x.long_words);
            }
        }

        private void Form3_profession_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!startFlag)
            {
                return;
            };

            // 计时并显示
            TimeCount = DateTime.Now - TimeNow;
            label_timing.Text = string.Format("{0:00}:{1:00}:{2:00}", TimeCount.Hours, TimeCount.Minutes, TimeCount.Seconds);

            if (e.KeyChar == '\r')
            {
                if (tb_procn.Text.Length != label_proen.Text.Length)
                {
                    tb_procn.ForeColor = Color.Red;
                    return;
                }

                if (tb_procn.Text == label_proen.Text)
                {
                    tb_procn.ForeColor = SystemColors.ControlText;
                    tb_procn.Text = "";
                }
                else
                {
                    tb_procn.ForeColor = Color.Red;
                    return;
                }

                if (lb_wordlist.Items.Count == 0)
                {
                    if (MessageBox.Show("点击“确定”继续打单词，点击“取消”返回主界面", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    {
                        this.Dispose();
                        new Home().Show();

                        return;
                    }

                    getWords();
                }

                reset();
                start();
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            start();
            btn_start.Enabled = false;
        }

        private void Form3_profession_Load(object sender, EventArgs e)
        {
            getWords();
        }

        private void Form3_profession_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("点击“确定”退出程序，点击“取消”返回主界面", "退出程序", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                System.Environment.Exit(0);
            }
            else
            {
                this.Hide();
                new Home().Show();
            }
        }
    }
}
