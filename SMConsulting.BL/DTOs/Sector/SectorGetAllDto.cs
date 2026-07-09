using SMConsulting.BL.DTOs.SectorHelp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.DTOs.Sector
{
    public class SectorGetAllDto
    {
        public int SectorId { get; set; }
        public string SectorName { get; set; }
        public string SectorDescription { get; set; }
        public string SectorCreatedAt { get; set; }
        public ICollection<SectorHelpGetAllDto> SectorHelps { get; set; }
    }
}
