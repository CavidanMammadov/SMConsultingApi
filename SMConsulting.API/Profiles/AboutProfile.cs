using AutoMapper;
using SMConsulting.BL.DTOs.About;
using SMConsulting.Core.Entities;

namespace SMConsulting.API.Profiles
{
    public class AboutProfile:Profile
    {
        public AboutProfile()
        {
            CreateMap<AboutCreateDto, About>();
            CreateMap<AboutUpdateDto, About>();
            CreateMap<About, AboutGetAllDto>();
        }
    }
}
