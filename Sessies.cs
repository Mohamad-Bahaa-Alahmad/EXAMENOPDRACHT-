using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News
{
    internal class Sessies
    {
        public string Title {  get; set; }
        public string Speaker { get; set; }
        public string Description {  get; set; }
        public string date {  get; set; }

        public Sessies(string title, string speaker, string desc, string start)
        {
            this.Title = title;
            this.Speaker = speaker;
            this.Description = desc;
            this.date = start;
        }
    }
}
