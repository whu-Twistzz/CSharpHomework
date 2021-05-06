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

namespace homework09_1
{
    class SimpleCrawler
    {
        public List<string> WaitingUrls { get; } = new List<string>();
        public List<string> DownloadUrls { get; } = new List<string>();
        public Dictionary<string, string> results = new Dictionary<string, string>();
        private static readonly Regex HREF_REGEX =
            new Regex(@"(?<=(href|HREF)\s*=\s*[""'])(?<url>[^#][^""'<>]*)(?=[""'])");
        private static readonly string PARSE_REGEX = @"^(?<site>(?<protocal>https?)://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
        public string StartURL { get; set; }
        public string HostFilter { get; set; }
        public string FileFilter= "((.html?|.aspx|.jsp|.php)$|^[^.]+$)";
        private int maxCount = 300;
        public Boolean isFisished = false;
        public void Crawl()
        {
            WaitingUrls.Clear();
            DownloadUrls.Clear();
            WaitingUrls.Add(StartURL);
            while (DownloadUrls.Count < maxCount && WaitingUrls.Count > 0)
            {
                foreach (var current in WaitingUrls.ToArray())
                {
                    try
                    {
                        string html = DownLoad(current);
                        DownloadUrls.Add(html);
                        Parse(html, current);
                        if (!results.ContainsKey(current))
                        {
                            results.Add(current, "success");
                        }
                        WaitingUrls.Remove(current);
                    }
                    catch (Exception e)
                    {
                        if (!results.ContainsKey(current))
                        {
                            results.Add(current, "error" + e.Message);
                        }
                        WaitingUrls.Remove(current);
                    }

                }
            }
            
        }

        public string DownLoad(string url)
        {                      
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = DownloadUrls.Count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;                       
        }

        private void Parse(string html,string currentUrl)
        {           
            MatchCollection matches = HREF_REGEX.Matches(html);
            foreach (Match match in matches)
            {
                string linkUrl = match.Groups["url"].Value;
                if (linkUrl == null || linkUrl == "" || linkUrl.StartsWith("javascript:")) continue;
                linkUrl = FixUrl(linkUrl, currentUrl);
                 Match linkUrlMatch = Regex.Match(linkUrl,PARSE_REGEX);
                string host = linkUrlMatch.Groups["host"].Value;
                HostFilter = "^" + host + "$";
                string file = linkUrlMatch.Groups["file"].Value;
                if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, FileFilter)
                && !DownloadUrls.Contains(linkUrl))
                {
                    WaitingUrls.Add(linkUrl);
                }
                }
        }
        static private string FixUrl(string url, string pageUrl)
        {
            if (url.Contains("://"))
            { 
                return url;
            }
            if (url.StartsWith("//"))
            {
                Match urlMatch = Regex.Match(pageUrl, PARSE_REGEX);
                string protocal = urlMatch.Groups["protocal"].Value;
                return protocal + ":" + url;
            }
            if (url.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(pageUrl, PARSE_REGEX);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }

            if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int idx = pageUrl.LastIndexOf('/');
                return FixUrl(url, pageUrl.Substring(0, idx));
            }

            if (url.StartsWith("./"))
            {
                return FixUrl(url.Substring(2), pageUrl);
            }
            
            int end = pageUrl.LastIndexOf("/");
            return pageUrl.Substring(0, end) + "/" + url;
        }
    }
}

 