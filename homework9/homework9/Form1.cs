using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace homework9
{
    public partial class Form1 : Form
    {
        BindingSource resultBindingSource = new BindingSource();
        Crawler crawler = new Crawler();

        public Form1()
        {
            InitializeComponent();
            Result.DataSource = resultBindingSource;
            crawler.PageDownloaded += Crawler_PageDownloaded;
            crawler.CrawlerStopped += Crawler_CrawlerStopped;
        }

        private void Crawler_CrawlerStopped(Crawler obj)
        {
            Action action = () => statelabel.Text = "爬取结束...";
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }
        private void Crawler_PageDownloaded(Crawler crawler, string url, string info)
        {
            var newpage = new { Index = resultBindingSource.Count + 1, URL = url, Status = info };
            Action action = () => { resultBindingSource.Add(newpage); };
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            //SimpleCrawler.Crawler myCrawler = new SimpleCrawler.Crawler();
            //myCrawler.Excute();

            resultBindingSource.Clear();
            crawler.StartURL = textStartURL.Text;
            int maxnumber;
            int.TryParse(textmax.Text, out maxnumber);
            crawler.MaxPage = maxnumber;

            Match match = Regex.Match(crawler.StartURL, Crawler.urlParseRegex);
            if (match.Length == 0) return;
            string host = match.Groups["host"].Value;
            crawler.HostFilter = "^" + host + "$";
            crawler.FileFilter = ".html?$";

            Task task = Task.Run(() => crawler.Excute());
            statelabel.Text = "爬虫已启动....";
        }

        private void maxnum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
