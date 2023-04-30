using HtmlAgilityPack;

namespace _01_Scraping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = "https://en.wikipedia.org/wiki/Main_Page";
            var web = new HtmlWeb();
            var doc = web.Load(url);

            var node = doc.DocumentNode.SelectSingleNode("//head//title");
            Console.WriteLine("Node Name: " + node.Name + "\n" + node.OuterHtml);
        }
    }
}