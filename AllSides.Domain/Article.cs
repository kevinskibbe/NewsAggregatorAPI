using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSides.Domain
{
    public class Article
    {
        public Source Source { get; set; }
        public string Headline { get; set; }
        public string Link { get; set; }
        public DateTime Dateline { get; set; }
        public string ImageUri { get; set; }
        public string Summary { get; set; }
    }
}
