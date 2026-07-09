using SMConsulting.BL.DTOs.Difficulty;
using SMConsulting.Core.Entities;
namespace SMConsulting.BL.DTOs.SectorHelp
{
    public class SectorHelpGetAllDto
    {
        public int SectorHelpId { get; set; }
        public string SectorHelpName { get; set; }
        public int SectorHelpSectorId { get; set; }
        public DateTime SectorHelpCreatedAt { get; set; }
        public ICollection<DifficultyGetAllDto> Difficulties { get; set; }
    }
}
