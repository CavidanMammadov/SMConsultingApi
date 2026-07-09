using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SMConsulting.BL.DTOs.Contact;
using SMConsulting.BL.Exceptions;
using SMConsulting.BL.Services.Abstracts;
using SMConsulting.Core.Entities;
using SMConsulting.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Services.Implements
{
    public class ContactService(IContacyRepository _repo, IMapper _mapper) : IContactService
    {
        public async Task<Contact> CreateAsync(ContactCreateDto dto)
        {
            Contact contact =  _mapper.Map<Contact>(dto);
            await _repo.AddAsync(contact);
            await _repo.SaveAsync();
            return contact;
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<Contact>();
            await _repo.RemoveAsync(id);
            await _repo.SaveAsync();
        }

        public async Task<IEnumerable<ContactGetAllDto>> GetAllAsync()
        {
            var datas = await _repo.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<ContactGetAllDto>>(datas);
        }

        public async Task<ContactGetAllDto> GetByIdAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);
           if (data is null ) throw new NotFoundException<Contact>();
           return _mapper.Map<ContactGetAllDto>(data);
        }

        public async Task<Contact> UpdateAsync(int id, ContactUpdateDto dto)
        {
            var data = await _repo.GetByIdAsync(id);
            if( data is null ) throw new NotFoundException<Contact>();
            _mapper.Map(dto,data);
            await _repo.SaveAsync();
            return data;

        }
    }
}
