using AutoMapper;
using SMConsulting.BL.DTOs.Team;
using SMConsulting.Core.Entities;

namespace SMConsulting.API.Profiles
{
    public class TeamProfile: Profile
    {
        public TeamProfile()
        {
            CreateMap<TeamCreateDto, Team>();
            CreateMap<TeamUpdateDto, Team>();
            CreateMap<Team, TeamGetAllDto>();
        }
    }
}
