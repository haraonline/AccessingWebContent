using HtmlAgilityPack;

namespace _01_Scraping
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //step 1
            //refer to the mark down file for explanation

            HttpClient client = new HttpClient();
            string html = await client.GetStringAsync("https://en.wikipedia.org/wiki/Main_Page");
            //Console.WriteLine(html);

            using (StreamWriter sw = new StreamWriter(@"C:\Users\harag\OneDrive\documents\Samples\wiki.html"))
            {
                sw.WriteLine(html);
            }
        }
    }
}