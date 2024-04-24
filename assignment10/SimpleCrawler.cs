using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCrawler
{
    class SimpleCrawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        private int threadNum = 5;    //线程数
        private static readonly object lockOBJ = new object();
        private int i = 1;
        static void Main(string[] args)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
            string startUrl = "http://www.cnblogs.com/dstang2000/";
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.urls.Add(startUrl, false);//加入初始页面

            //new Thread(myCrawler.Crawl).Start();
            myCrawler.Crawl();          
        }

        private void Crawl()
        {
            Console.WriteLine($"开始爬行了.... ");

            List<Task> tasks = new List<Task>();
            while (true)
            {
                string current = null;
                lock(lockOBJ)
                {
                    current = urls.Keys.Cast<string>().FirstOrDefault(url => !(bool)urls[url]);

                    if (current != null)
                    {
                        string html = DownLoad(current); // 下载
                        urls[current] = true;
                        Parse(html);//解析,并加入新的链接
                    }             
                }
                                   

                if (current == null || count > 10) break;

                tasks.Add(Task.Run(() =>
                {
                    Console.WriteLine("爬行" + current + "页面!");
                    
                    Console.WriteLine($"爬行结束");
                }) );

                count++;
            }
            Task.WaitAll(tasks.ToArray());
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                /*if (urls[strRef] == null) {
                    urls[strRef] = false;
                } */
                
                lock (lockOBJ)
                {
                    if (urls[strRef] == null)
                    {
                        urls.Add(strRef, false);
                    }
                }
            }
        }
    }
}
