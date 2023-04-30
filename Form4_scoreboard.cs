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
using FnClass.Http;
using System.IO;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace keymanx
{
    public partial class Form4_scoreboard : Form
    {
        Dictionary<string, int> recode = new Dictionary<string, int>();

        string level = "primary";

        public Form4_scoreboard()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            Thread receiveFromMulticastThread = new Thread(() =>
            {
                UdpClient client = new UdpClient(8002);
                client.JoinMulticastGroup(IPAddress.Parse("234.0.0.25"));
                IPEndPoint remotePoint = new IPEndPoint(IPAddress.Parse("234.0.0.25"), 8001);

                while (true)
                {
                    byte[] receiveData = client.Receive(ref remotePoint);
                    string receiveString = Encoding.Default.GetString(receiveData);

                    string[] score = receiveString.Split('#');
                    string score_type = score[2];

                    string clas = score[0].Split(' ')[0];
                    string name = score[0].Split(' ')[1];

                    AddScoreToYaml(clas, name, score[1], score_type);
                    AddToExcel(clas, name, int.Parse(score[1]), score_type);

                    if (score_type != level)
                    {
                        continue;
                    }

                    //检查是否存在成绩
                    if (recode.Keys.Contains(score[0]))
                    {
                        //检查最新成绩是否优于存在成绩
                        if (recode[score[0]] > int.Parse(score[1]))
                        {
                            recode[score[0]] = int.Parse(score[1]);
                        }
                    }
                    else
                    {
                        recode.Add(score[0], int.Parse(score[1]));
                    }

                    DisplayScore();
                }
            });

            receiveFromMulticastThread.Name = "receiveFromMulticastThread";
            receiveFromMulticastThread.Start();
        }

        private void DisplayScore()
        {
            //清空计分板
            ranklist1.Items.Clear();
            ranklist2.Items.Clear();
            ranklist3.Items.Clear();
            ranklist4.Items.Clear();

            //以字典Value值顺序排序
            Dictionary<string, int> dic1Asc = recode.OrderBy(o => o.Value).ToDictionary(o => o.Key, p => p.Value);

            int Counter = 0;

            foreach (KeyValuePair<string, int> kvp in dic1Asc)
            {
                if (Counter <= 29)
                {
                    ranklist1.Items
                        .Add((Counter + 1).ToString())
                        .SubItems.AddRange(new string[] { kvp.Key, kvp.Value.ToString() });
                }
                else if (Counter <= 59)
                {
                    ranklist2.Items
                        .Add( (Counter + 1).ToString() )
                        .SubItems.AddRange(new string[] { kvp.Key, kvp.Value.ToString() });
                }
                else if (Counter <= 89)
                {
                    ranklist3.Items
                        .Add( (Counter + 1).ToString() )
                        .SubItems.AddRange(new string[] { kvp.Key, kvp.Value.ToString() });
                }
                else
                {
                    ranklist4.Items
                        .Add( (Counter + 1).ToString() )
                        .SubItems.AddRange(new string[] { kvp.Key, kvp.Value.ToString() });
                }

                Counter++;
            }

            int winer = Convert.ToInt32(dic1Asc.Keys.ToArray().Length * 40 / 100);
            Console.WriteLine(winer);

            if (winer > 30)
            {
                ranklist1.ForeColor = Color.Green;
                
                if (winer > 60)
                {
                    ranklist2.ForeColor = Color.Green;

                    if (winer > 90)
                    {
                        ranklist3.ForeColor = Color.Green;
                    }
                    else
                    {
                        for (int i = 0; i < winer - 90; i++)
                        {
                            ranklist3.Items[i].ForeColor = Color.Green;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < winer - 30; i++)
                    {
                        ranklist2.Items[i].ForeColor = Color.Green;
                    }
                }
            }
            else
            {
                if (winer <= 1)
                {
                    ranklist1.Items[0].ForeColor = Color.Green;
                }
                else
                {
                    for (int i = 0; i < winer; i++)
                    {
                        ranklist1.Items[i].ForeColor = Color.Green;
                    }
                }
            }

        }

        // 向 Yaml 增加成绩数据
        private void AddScoreToYaml(string clas, string name, string score, string level)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();

            data[name] = new Dictionary<string, string>{
                { "clas", clas},
                { "score", score},
                { "level", level },
                { "uploadDate", System.DateTime.Now.ToString("yyyy-MM-dd HH:mm")}
            };

            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();
            var yaml = serializer.Serialize(data);

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string filePath = Path.Combine(desktopPath, System.DateTime.Now.ToString("D") + "比赛成绩记录.yml");

            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(yaml);
            };
        }

        // 展示 Yaml 的数据到窗口
        private void ShowYamlToForm()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string filePath = Path.Combine(desktopPath, System.DateTime.Now.ToString("D") + "比赛成绩记录.yml");

            recode.Clear();

            if (File.Exists(filePath))
            {
                var deserializer = new DeserializerBuilder()
                                .WithNamingConvention(UnderscoredNamingConvention.Instance)
                                .Build();
                string yml = File.ReadAllText(filePath);

                var p = deserializer.Deserialize<dynamic>(yml);

                foreach (var a in p)
                {
                    if (a.Value["level"] == level)
                    {
                        string ClassAndName = a.Value["clas"] + ' ' + a.Key;
                        recode.Add(ClassAndName, int.Parse(a.Value["score"]));
                    }
                }

                if (recode.Count > 0)
                {
                    DisplayScore();
                }
            }
        }

        // 把成绩数据导出为 Excel
        private void AddToExcel(string clas, string name, int score, string level)
        {
            Task.Run(() =>
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string filePath = Path.Combine(desktopPath, System.DateTime.Now.ToString("D") + "比赛成绩记录.xlsx");

                Excel.Application excel = new Excel.Application();
                Excel.Workbook workbook;
                Excel.Worksheet worksheet;

                if (!File.Exists(filePath))
                {
                    // 新建Excel文件并打开
                    workbook = excel.Workbooks.Add();
                    worksheet = workbook.ActiveSheet;

                    worksheet.Cells[1, 1] = "班级";
                    worksheet.Cells[1, 2] = "姓名";
                    worksheet.Cells[1, 3] = "成绩";
                    worksheet.Cells[1, 4] = "等级";
                    worksheet.Cells[1, 5] = "上传时间";

                    workbook.SaveAs(filePath);
                }

                // 打开已经存在的Excel文件
                workbook = excel.Workbooks.Open(filePath);
                worksheet = workbook.ActiveSheet;

                int lastRow = worksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;

                worksheet.Cells[lastRow + 1, 1] = clas;
                worksheet.Cells[lastRow + 1, 2] = name;
                worksheet.Cells[lastRow + 1, 3] = score;
                worksheet.Cells[lastRow + 1, 4] = level;
                worksheet.Cells[lastRow + 1, 5] = System.DateTime.Now.ToString("yyyy年MM月dd HH:mm"); ;

                workbook.Save();

                workbook.Close();

                excel.Quit();
            });
        }

        private void Form4_scoreboard_Load(object sender, EventArgs e)
        {
            // 默认接收的成绩类型
            button1.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            level = "primary";
            button1.Enabled = false;
            button2.Enabled = true;

            ranklist1.Items.Clear();
            ranklist2.Items.Clear();
            ranklist3.Items.Clear();
            ranklist4.Items.Clear();

            ShowYamlToForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            level = "senior";
            button1.Enabled = true;
            button2.Enabled = false;

            ranklist1.Items.Clear();
            ranklist2.Items.Clear();
            ranklist3.Items.Clear();
            ranklist4.Items.Clear();

            ShowYamlToForm();
        }

        private void Form4_scoreboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void ranklist_Leave(object sender, EventArgs e)
        {
            ((ListView)sender).SelectedItems.Clear();
        }
    }
}
