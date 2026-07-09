using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.Core.Entities
{
    public class Value
    {
        public int ValueId { get; set; }
        public string ValueTitle { get; set; }
        public string ValueDescription { get; set; }
        public string ValueFooterTitle { get; set; }
        public string ValueFooterDescription { get; set; }
        public DateTime ValueCreatedAt { get; set; }= DateTime.Now;
    }
}
