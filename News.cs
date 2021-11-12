using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News
{
    internal class News
    {
        public string Title {  get; set; }
        public string Text {  get; set; }
        public string dateTime { get; set; }

        public News(string title, string text, string date)
        {
            Title = title;
            Text = text;
            dateTime = date;
        }
    }
}
