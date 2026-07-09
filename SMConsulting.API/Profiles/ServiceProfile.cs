using AutoMapper;
using SMConsulting.BL.DTOs.Services;
using SMConsulting.Core.Entities;

namespace SMConsulting.API.Profiles
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            CreateMap<ServiceCreateDto, Service>();
            CreateMap<ServiceUpdateDto, Service>();
            CreateMap<Service, ServiceGetAllDto>();
        }
    }
}
