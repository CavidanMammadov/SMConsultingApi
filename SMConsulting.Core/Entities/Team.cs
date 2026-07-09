using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.Core.Entities
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamTitle { get; set; }
        public string TeamTitleHiglight { get; set; }
        public string TeamDescription { get; set; }
        public DateTime TeamCreatedAt { get; set; } = DateTime.Now;
    }
}
