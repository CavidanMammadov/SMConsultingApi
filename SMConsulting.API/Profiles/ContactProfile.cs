using AutoMapper;
using SMConsulting.BL.DTOs.Contact;
using SMConsulting.Core.Entities;

namespace SMConsulting.API.Profiles
{
    public class ContactProfile :Profile
    {
        public ContactProfile()
        {
            CreateMap<ContactCreateDto, Contact>();
            CreateMap<ContactUpdateDto, Contact>();
            CreateMap<Contact, ContactGetAllDto>();
        }
    }
}
