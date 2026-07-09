using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.Core.Entities
{
    public class SectorHelp
    {
        public int SectorHelpId { get; set; }
        public string SectorHelpName { get; set; }
        public int SectorHelpSectorId { get; set; }
        public DateTime SectorHelpCreatedAt { get; set; } = DateTime.Now;
        public Sector Sector { get; set; }
        public ICollection<Difficulty> Difficulties { get; set; }
    }
}
