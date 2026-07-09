using AutoMapper;
using SMConsulting.BL.DTOs.Value;
using SMConsulting.Core.Entities;

namespace SMConsulting.API.Profiles
{
    public class ValueProfile :Profile
    {
        public ValueProfile()
        {
            CreateMap<ValueCreateDto, Value>();
            CreateMap<ValueUpdateDto, Value>();
            CreateMap<Value,ValueGetAllDto>();
        }
    }
}
