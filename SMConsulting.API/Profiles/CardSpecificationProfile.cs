using AutoMapper;
using SMConsulting.BL.DTOs.Card;
using SMConsulting.BL.DTOs.CardSpecifications;
using SMConsulting.Core.Entities;

namespace SMConsulting.API.Profiles
{
    public class CardSpecificationProfile :Profile
    {
        public CardSpecificationProfile()
        {
            CreateMap<CardCreateDto,CardSpecification>();
            CreateMap<CardSpecificationUpdateDto,CardSpecification>();
            CreateMap<CardSpecification, CardSpecificationGetAllDto>();
        }
    }
}
