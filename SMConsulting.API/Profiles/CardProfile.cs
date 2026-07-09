using AutoMapper;
using SMConsulting.BL.DTOs.Card;
using SMConsulting.Core.Entities;

namespace SMConsulting.API.Profiles
{
    public class CardProfile :Profile
    {
        public CardProfile()
        {
            CreateMap<CardCreateDto, Card>();
            CreateMap<CardUpdateDto, Card>();
            CreateMap<Card, CardGetAllDto>();
        }
    }
}
