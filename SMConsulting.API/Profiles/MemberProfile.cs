using AutoMapper;
using SMConsulting.BL.DTOs.Member;
using SMConsulting.Core.Entities;

namespace SMConsulting.API.Profiles
{
    public class MemberProfile :Profile
    {
        public MemberProfile()
        {
            CreateMap<MemberCreateDto, Member>();
            CreateMap<MemberUpdateDto, Member>();
            CreateMap<Member, MemberGetAllDto>();
        }
    }
}
