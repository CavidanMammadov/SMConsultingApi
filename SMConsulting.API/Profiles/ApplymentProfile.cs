using AutoMapper;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;
using SMConsulting.BL.DTOs.Applyment;
using SMConsulting.Core.Entities;

namespace SMConsulting.API.Profiles
{
    public class ApplymentProfile :Profile
    {
        public ApplymentProfile()
        {
            CreateMap<ApplymentCreateDto, Applyment>();
            CreateMap<ApplymentUpdateDto, Applyment>();
            CreateMap<Applyment, ApplymentGetAllDto>();
        }
    }
}
