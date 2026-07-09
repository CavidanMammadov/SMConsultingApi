using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.Core.Entities
{
    public class Partner
    {
        public int PartnerId { get; set; }
        public string PartnerName { get; set; }
        public string PartnerDescription { get; set; }
        public string  PartnerImage  { get; set; }
        public string PartnerWebsiteUrl { get; set; }
        public DateTime PartnerCreatedAt { get; set; } = DateTime.Now;
    }
}
