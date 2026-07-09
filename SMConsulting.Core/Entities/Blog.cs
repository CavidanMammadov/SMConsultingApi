using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.Core.Entities
{
    public class Blog
    {
        public int BlogId    { get; set; }
        public string BlogTitle { get; set; }
        public string BlogMainImage { get; set; }
        public string BlogSecondaryImage { get; set; }
        public string BlogMainContent { get; set; }
        public string BlogSubcontent { get; set; }
        public string BlogTags { get; set; }
        public DateTime BlogCreatedAt { get; set; } = DateTime.Now;
    }
}
