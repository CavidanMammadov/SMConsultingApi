using SMConsulting.BL.DTOs.Contact;
using SMConsulting.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Services.Abstracts
{
    public interface IContactService
    {
        Task<Contact> CreateAsync(ContactCreateDto dto);
        Task<Contact> UpdateAsync(int id, ContactUpdateDto dto);
        Task<IEnumerable<ContactGetAllDto>> GetAllAsync();
        Task<ContactGetAllDto> GetByIdAsync(int id);
        Task DeleteAsync (int id);
    }
}
