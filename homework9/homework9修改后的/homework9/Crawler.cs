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
        public Dictionary<string, bool> AlreadyDownload = new Dictionary<string, bool>();
        private Queue<string> WaitforDownload = new Queue<string>();
        private readonly string urlDetectRegex = @"(href|HREF)[]*=[]*[""'](?<url>[^""'#>]+)[""']";
        public static readonly string urlParseRegex = @"^(?<site>https?://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
        public string HostFilter { get; set; } 
        public string FileFilter { get; set; }
        public string StartURL { get; set; } 
        public int MaxPage { get; set; } 
        public Encoding HtmlEncoding { get; set; } 
        public Dictionary<string, bool> DownloadedPages { get; }
        public int Downloadnumber { get; set; }
        public Crawler()
        {
            HtmlEncoding = Encoding.UTF8;
        }

        public void Excute()
        {
            AlreadyDownload.Clear();
            WaitforDownload.Clear();
            Downloadnumber = 0;
            WaitforDownload.Enqueue(StartURL);
            Crawl();
        }


        public string DownLoad(string url)
        {
                WebClient webClient = new WebClient();
                webClient.Encoding = HtmlEncoding;
                string html = webClient.DownloadString(url);
                string fileName = "number." + AlreadyDownload.Count.ToString();
                File.WriteAllText(fileName, html, HtmlEncoding);
                return html;
        }

        private void Parse(string html, string startUrl)
        {
            var matches = new Regex(urlDetectRegex).Matches(html);
            foreach (Match match in matches)
            {
                if (AlreadyDownload.Count >= MaxPage)
                {
                    WaitforDownload.Clear();
                    break;
                }
                string linkUrl = match.Groups["url"].Value;
                if (linkUrl == null || linkUrl == "" || linkUrl.StartsWith("javascript:")) continue;
                linkUrl = ToAbsoluteUrl(linkUrl, startUrl);//转绝对路径
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
            while (Downloadnumber < MaxPage && WaitforDownload.Count > 0)
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
            if (url.StartsWith("//"))
            {
                Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                string protocal = urlMatch.Groups["protocal"].Value;
                return protocal + ":" + url;
            }

            int end = pageUrl.LastIndexOf("/");
            return pageUrl.Substring(0, end) + "/" + url;
        }
    }
}
