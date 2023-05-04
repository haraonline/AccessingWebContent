using HtmlAgilityPack;
using HtmlAgilityPack.CssSelectors.NetCore;
using static System.Net.WebRequestMethods;

namespace _02_HtmlAgilityPack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = "https://scrapeme.live/shop/";
            HtmlWeb web = new HtmlWeb();
            var doc = web.Load(url);

            //QuerySelector and QuerySelectorAll

            Console.WriteLine(doc.GetType());
            Console.WriteLine(doc.Encoding);
            Console.WriteLine(doc.DocumentNode.SelectSingleNode("//head/title").InnerText);
            Console.WriteLine(doc.DocumentNode.SelectSingleNode("//head/title").InnerHtml);
            Console.WriteLine(doc.DocumentNode.SelectSingleNode("//head/title").OuterHtml);
            var all = doc.QuerySelectorAll("li.product");

            Console.WriteLine(all.Count());
            foreach ( var item in all )
            {
                Console.WriteLine(item.InnerHtml);
            }
        }
    }
}