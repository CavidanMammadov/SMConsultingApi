using AutoMapper;
using SMConsulting.BL.DTOs.Sector;
using SMConsulting.BL.DTOs.SectorHelp;
using SMConsulting.Core.Entities;

namespace SMConsulting.API.Profiles
{
    public class SectorProfile:Profile
    {
        public SectorProfile()
        {
            CreateMap<SectorCreateDto, Sector>();
            CreateMap<SectorUpdateDto, Sector>();
            CreateMap<Sector,SectorGetAllDto>();
            CreateMap<SectorHelp, SectorHelpItemDto>();
        }
    }
}
