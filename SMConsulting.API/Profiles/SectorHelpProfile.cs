using AutoMapper;
using SMConsulting.BL.DTOs.SectorHelp;
using SMConsulting.Core.Entities;

namespace SMConsulting.API.Profiles
{
    public class SectorHelpProfile :Profile
    {
        public SectorHelpProfile()
        {
            CreateMap<SectorHelpCreateDto, SectorHelp>();
            CreateMap<SectorHelpUpdateDto, SectorHelp>();
            CreateMap<SectorHelp, SectorHelpGetAllDto>();
        }
    }
}
