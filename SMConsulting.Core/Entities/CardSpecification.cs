using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.Core.Entities
{
    public class CardSpecification
    {
        public int CardSpecificationId { get; set; }
        public string CardSpecificationTitle { get; set; }
        public string CardSpecificationIcon { get; set; }
        public List<string> CardSpecificationDescription { get; set; }
        public DateTime CardSpecificationCreatedAt { get; set; } = DateTime.Now;
    }
}
