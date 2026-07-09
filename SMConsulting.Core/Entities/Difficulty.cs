using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.Core.Entities
{
    public class Difficulty
    {
        public int DifficultyId { get; set; }
        public string DifficultyDescription { get; set; }
        public int   DifficultSectorHelpId  { get; set; }
        public DateTime DifficultyCreatedAt { get; set; } = DateTime.Now;
        public SectorHelp SectorHelp { get; set; }
    }
}
