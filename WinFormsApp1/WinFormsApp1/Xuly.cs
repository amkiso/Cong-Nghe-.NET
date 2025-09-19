using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using HtmlAgilityPack;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Xuly
    {
        public Xuly() { }
        public async Task<string> GetHtmlCodeAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");

                string html = await client.GetStringAsync(url);

                var htmlDoc = new HtmlAgilityPack.HtmlDocument();
                htmlDoc.LoadHtml(html);

                return htmlDoc.DocumentNode.OuterHtml;
            }
        }
        public List<string> GetElementsByTagName(HtmlAgilityPack.HtmlDocument doc, string tagName)
        {
            return doc.DocumentNode
                      .Descendants(tagName)
                      .Select(n => n.OuterHtml)
                      .ToList();
        }

        // Lấy theo tên thẻ + class
        public List<string> GetElementsByTagAndClass(HtmlAgilityPack.HtmlDocument doc, string tagName, string className)
        {
            return doc.DocumentNode
                      .Descendants(tagName)
                      .Where(n => n.GetAttributeValue("class", "")
                                   .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                   .Contains(className))
                      .Select(n => n.OuterHtml)
                      .ToList();
        }
    }
}