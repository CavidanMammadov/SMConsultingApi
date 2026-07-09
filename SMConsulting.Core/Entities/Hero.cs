using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.Core.Entities
{
    public class Hero
    {
        public int HeroId { get; set; }
        public string HeroTitle { get; set; }
        public string HeroDescription { get; set; }
        public string HeroImageUrl { get; set; }
        public DateTime HeroCreatedAt { get; set; } = DateTime.Now;
    }
}
