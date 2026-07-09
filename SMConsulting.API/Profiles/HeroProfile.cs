using AutoMapper;
using SMConsulting.BL.DTOs.Hero;
using SMConsulting.Core.Entities;

namespace SMConsulting.API.Profiles
{
    public class HeroProfile : Profile
    {
        public HeroProfile()
        {
            CreateMap<HeroCreateDto, Hero>();
            CreateMap<HeroUpdateDto, Hero>();
            CreateMap<Hero,HeroGetAllDto>();
        }

    }
}
