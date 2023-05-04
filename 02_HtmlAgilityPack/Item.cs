using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_HtmlAgilityPack
{
    internal class Item
    {
        public string Url { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }

        public Item(string url, string title, string name, string price)
        {
            Url = url;
            Title = title;
            Name = name;
            Price = price;            
        }
    }
}
