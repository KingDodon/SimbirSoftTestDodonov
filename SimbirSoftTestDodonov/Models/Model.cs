using System;
using System.Collections.Generic;
using System.Text;
using SimbirSoftTestDodonov.Models;
using System.Net;
using HtmlAgilityPack;

namespace SimbirSoftTestDodonov.Models
{
    class Model: IModel
    {
        private string Download(string address)
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(address, "WebSite.html");
                string htmlCode = client.DownloadString(address);
                return htmlCode;
            }
        }
        public Dictionary<string, int> Statistics(string address)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(Download(address));
            char[] delimiterChars = { ' ', ',', '.', '!', '?', '"', ';', ':', '[', ']', '(', ')', '\n', '\r', '\t' };
            string[] words = doc.DocumentNode.InnerText.Split(delimiterChars);
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (string s in words)
            {
                if (s.Length > 1)
                {
                    if (dic.ContainsKey(s))
                    {
                        dic[s] += 1;
                    }
                    else
                    {
                        dic.Add(s, 1);
                    }
                }

            }
            return dic;
        }
    }
}
