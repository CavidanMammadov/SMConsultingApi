using AutoMapper;
using SMConsulting.BL.DTOs.Difficulty;
using SMConsulting.Core.Entities;

namespace SMConsulting.API.Profiles
{
    public class DifficultyProfile :Profile
    {
        public DifficultyProfile()
        {
            CreateMap<DifficultyCreateDto, Difficulty>();
            CreateMap<DifficultyUpdateDto, Difficulty>();
            CreateMap<Difficulty, DifficultyGetAllDto>();   
        }
    }
}
