using AutoMapper;
using SMConsulting.BL.DTOs.Partner;
using SMConsulting.Core.Entities;

namespace SMConsulting.API.Profiles
{
    public class PartnerProfile : Profile
    {
        public PartnerProfile()
        {
            CreateMap<PartnerCreateDto, Partner>()
                .ForMember(x => x.PartnerImage, opt => opt.Ignore());
            CreateMap<PartnerUpdateDto, Partner>()
                .ForMember(x=>x.PartnerImage, opt => opt.Ignore());
        
        CreateMap<Partner, PartnerGetAllDto>();

        }
    }
}
