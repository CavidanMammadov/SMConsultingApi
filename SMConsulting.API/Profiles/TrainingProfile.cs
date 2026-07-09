using AutoMapper;
using SMConsulting.BL.DTOs.Training;
using SMConsulting.Core.Entities;

namespace SMConsulting.API.Profiles
{
    public class TrainingProfile :Profile
    {
        public TrainingProfile()
        {
            CreateMap<TrainingCreateDto, Training>();
            CreateMap<TrainingUpdateDto, Training>();
            CreateMap<Training, TrainingGetAllDto>();
        }
    }
}
