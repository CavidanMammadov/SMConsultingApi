using AutoMapper;
using SMConsulting.BL.DTOs.Auth;
using SMConsulting.BL.Helpers;
using SMConsulting.Core.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SMConsulting.API.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<RegisterDto, User>()
              .ForMember(x => x.UserPasswordHash, x => x.MapFrom(y => HashHelper.HashPassword(y.UserPassword)));
        }

    }
}
