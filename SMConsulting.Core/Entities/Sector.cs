using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.Core.Entities
{
    public class Sector
    {
        public int SectorId { get; set; }
        public string SectorName { get; set; }
        public string SectorDescription { get; set; }
        public DateTime SectorCreatedAt { get; set; } = DateTime.Now;
        public ICollection<SectorHelp> SectorHelps { get; set; }
    }
}
