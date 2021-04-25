using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;

namespace homework9
{
    public class Crawler
    {
        public event Action<Crawler> CrawlerStopped;
        public event Action<Crawler, string, string> PageDownloaded;
        
        private Dictionary<string, bool> AlreadyDownload = new Dictionary<string, bool>();//<URL,(bool)成功?>

        
        private Queue<string> WaitforDownload = new Queue<string>();

        //URL检测表达式，用于在HTML文本中查找URL
        private readonly string urlDetectRegex = @"(href|HREF)[]*=[]*[""'](?<url>[^""'#>]+)[""']";

        //URL解析表达式
        public static readonly string urlParseRegex = @"^(?<site>https?://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";

        public string HostFilter { get; set; } //主机过滤规则
        public string FileFilter { get; set; } //文件过滤规则
        public string StartURL { get; set; } //起始网址
        public int MaxPage { get; set; } //最大下载数量
        public Encoding HtmlEncoding { get; set; } //网页编码
        public Dictionary<string, bool> DownloadedPages { get; } //已下载网页

        public Crawler()
        {
            HtmlEncoding = Encoding.UTF8;
        }

        public void Excute()
        {
            AlreadyDownload.Clear();
            WaitforDownload.Clear();
            WaitforDownload.Enqueue(StartURL);
            Crawl();
        }


        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = HtmlEncoding;
                string html = webClient.DownloadString(url);
                string fileName = AlreadyDownload.Count.ToString();
                File.WriteAllText(fileName, html, HtmlEncoding);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html, string startUrl)
        {
            MatchCollection matches = new Regex(urlDetectRegex).Matches(html);
            foreach (Match match in matches)
            {
                if (AlreadyDownload.Count >= MaxPage)
                {
                    WaitforDownload.Clear();
                    break;
                }
                string linkUrl = match.Groups["url"].Value;
                if (linkUrl == null || linkUrl == "") continue;
                linkUrl = ToAbsoluteUrl(linkUrl, startUrl);//转绝对路径
                                                    //解析出host和file两个部分，进行过滤
                Match linkUrlMatch = Regex.Match(linkUrl, urlParseRegex);
                string host = linkUrlMatch.Groups["host"].Value;
                string file = linkUrlMatch.Groups["file"].Value;
                if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, FileFilter)
                  && !AlreadyDownload.ContainsKey(linkUrl))
                {
                    WaitforDownload.Enqueue(linkUrl);
                }

            }
        }

        private void Crawl()
        {

            //爬取
            while (AlreadyDownload.Count < MaxPage && WaitforDownload.Count > 0)
            { 
                string url = WaitforDownload.Dequeue();
                try
                {
                    string html = DownLoad(url); // 下载
                    AlreadyDownload[url] = true;
                    PageDownloaded(this, url, "success");
                    //解析,并加入新的链接
                    Parse(html, url);
                }
                catch (Exception ex)
                {
                    PageDownloaded(this, url, "  Error:" + ex.Message);
                }
            }
            CrawlerStopped(this);
        }


        //将相对路径转为绝对路径
        private string ToAbsoluteUrl(string url, string pageUrl)
        {
            if (url.Contains("://"))
            {
                return url;
            }
            if (url.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }

            if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int idx = pageUrl.LastIndexOf('/');
                return ToAbsoluteUrl(url, pageUrl.Substring(0, idx));
            }

            if (url.StartsWith("./"))
            {
                return ToAbsoluteUrl(url.Substring(2), pageUrl);
            }
            if (url.Contains("://"))
            {
                return url;
            }
            if (url.StartsWith("//"))
            {
                return "http:" + url;
            }

            int end = pageUrl.LastIndexOf("/");
            return pageUrl.Substring(0, end) + "/" + url;
        }
    }
}
