using AutoMapper;
using SMConsulting.BL.DTOs.SocialMedia;
using SMConsulting.Core.Entities;

namespace SMConsulting.API.Profiles
{
    public class SocialMediaProfile:Profile
    {
        public SocialMediaProfile()
        {
            CreateMap<SocialMediaCreateDto, SocialMedia >();
            CreateMap<SocialMediaUpdateDto, SocialMedia >();
            CreateMap<SocialMedia, SocialMediaGetAllDto>(); 
        }
    }
}
