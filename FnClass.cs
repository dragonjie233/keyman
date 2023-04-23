using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FnClass
{
    namespace Form
    {
        // 按键转窗口控件
        public class Key2Btn
        {
            private dynamic key;

            public Key2Btn(dynamic key)
            {
                this.key = key;
            }

            public string conv()
            {
                dynamic key = this.key;

                // 参数为 int 类型，则先过滤为字母
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

                // 按键对应控件表
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
        }
    }

    namespace Http
    {
        // HTTP GET METHOD
        public class Get
        {
            private string url = "";

            public Get(string url)
            {
                this.url = url;
            }

            public object getData()
            {
                WebClient webClient = new WebClient();
                string res;

                try
                {
                    webClient.Headers["content-type"] = "application/json; charset=UTF-8";

                    res = webClient.DownloadString(this.url);

                    return JsonConvert.DeserializeObject(res);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                return false;
            }
        }

        // HTTP POST METHOD
        public class Post
        {
            private string url = "";

            public Post(string url)
            {
                this.url = url;
            }

            public bool postData(Dictionary<string, object> dictData)
            {
                WebClient webClient = new WebClient();
                byte[] resByte;
                string resString;
                byte[] reqString;

                try
                {
                    webClient.Headers["content-type"] = "application/json; charset=UTF-8";

                    reqString = Encoding.Default.GetBytes(JsonConvert.SerializeObject(
                        dictData,
                        Formatting.Indented,
                        //解决JSON转换解决中文编码问题
                        new JsonSerializerSettings()
                        {
                            StringEscapeHandling = StringEscapeHandling.EscapeNonAscii
                        }
                    ));

                    resByte = webClient.UploadData(this.url, "post", reqString);
                    resString = Encoding.Default.GetString(resByte);
                    Console.WriteLine(resString);
                    webClient.Dispose();

                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                return false;
            }
        }
    }
}
