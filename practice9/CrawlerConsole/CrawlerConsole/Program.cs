using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace CrawlerConsole
{
    class Program
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        private String startUrl = "http://image.baidu.com/search/index?tn=baiduimage&ps=1&ct=201326592&lm=-1&cl=2&nc=1&ie=utf-8&word=%E6%AD%A6%E5%8F%88%E5%B8%A6%E5%AD%A6";
        static void Main(string[] args)
        {
            Program myCrawler = new Program();
            if (args.Length >= 1) myCrawler.startUrl = args[0];
            myCrawler.urls.Add(myCrawler.startUrl, false);//加入初始页面
            new Thread(myCrawler.Crawl).Start();
        }

        private void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }
                
                if (current == null || count > 10 ) break;
                string html = tryDownLoad(current); // 下载
                Console.WriteLine("爬行" + current + "页面!");
                urls[current] = true;
                count++;
                Parse(html);//解析,并加入新的链接
                Console.WriteLine("爬行结束");
            }
            Console.ReadKey();
        }

        public string tryDownLoad(string url)
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
            if(html.Contains("<!DOCTYPE html>"))
            {
                string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
                MatchCollection matches = new Regex(strRef).Matches(html);
                foreach (Match match in matches)
                {
                    strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                              .Trim('"', '\"', '#', '>');
                    if (strRef.Length == 0) continue;
                    if (strRef.Contains(startUrl))
                    {
                        if (urls[strRef] == null) urls[strRef] = false;
                    }
                }
            }

        }
    }
}
