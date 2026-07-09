using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.Core.Entities
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceDescription { get; set; }
        public string ServiceFooter { get; set; }
        public string ServiceFooterDescription { get; set; }
        public DateTime ServiceCreatedAt { get; set; } = DateTime.Now;
    }
}
