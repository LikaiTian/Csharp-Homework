using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework10
{
    public partial class Form1 : Form
    {
        SimpleCrawler crawler = new SimpleCrawler();
        BindingSource resultBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            dgvResult.DataSource = resultBindingSource;
            crawler.PageDownloaded += Crawler_PageDownloaded;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultBindingSource.Clear();
            crawler.StartURL = textBox1.Text;

            Match match = Regex.Match(crawler.StartURL, SimpleCrawler.urlParseRegex);
            if (match.Length == 0) return;
            string host = match.Groups["host"].Value;
            crawler.HostFilter = "^" + host + "$";
            crawler.FileFilter = "((.html?|.aspx|.jsp|.php)$|^[^.]+$)";
            //new Thread(crawler.Start).Start();
            Parallel.Invoke(new Action[]
            {
                ()=>crawler.Start(),
                ()=>crawler.Start()
            });
        }
        private void Crawler_PageDownloaded(SimpleCrawler crawler, string url, string info)
        {
            var pageInfo = new { Index = resultBindingSource.Count + 1, URL = url, Status = info };
            Action action = () => { resultBindingSource.Add(pageInfo); };
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
}
