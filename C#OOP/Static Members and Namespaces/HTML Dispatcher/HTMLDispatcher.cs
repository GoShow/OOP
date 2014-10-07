using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTML_Dispatcher
{
    class HTMLDispatcher
    {
        public static void Main()
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAttribute("id", "goshow");
            div.AddAttribute("class", "red");
            div.AddContent("Hello C#!");

            ElementBuilder article = new ElementBuilder("article");
            article.AddAttribute("class", "news");
            article.AddContent("This is some text inside the article");

            ElementBuilder span = new ElementBuilder("span");
            span.AddContent("<p>Text inside span</p>");
            
            Console.WriteLine(div);
            Console.WriteLine(article);
            Console.WriteLine(span * 2);
        }
    }
}
