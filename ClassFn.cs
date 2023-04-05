using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ClassFn
{
    // Request Function Class
    internal class Http
    {
        // GET METHOD
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

        // POST METHOD
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
                        //为了解决JSON转换解决中文编码问题
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
