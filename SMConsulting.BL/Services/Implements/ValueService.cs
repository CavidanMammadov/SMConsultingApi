using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SMConsulting.BL.DTOs.Value;
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
    public class ValueService(IValueRepository _repo, IMapper _mapper) : IValueService
    {
        public async Task<Value> CreateAsync(ValueCreateDto dto)
        {
            Value value = _mapper.Map<Value>(dto);

            await _repo.AddAsync(value);
            await _repo.SaveAsync();

            return value;
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);

            if (data is null)
                throw new NotFoundException<Value>();

            await _repo.RemoveAsync(id);
            await _repo.SaveAsync();
        }

        public async Task<IEnumerable<ValueGetAllDto>> GetAllAsync()
        {
            var datas = await _repo.GetAll().ToListAsync();

            return _mapper.Map<IEnumerable<ValueGetAllDto>>(datas);
        }

        public async Task<ValueGetAllDto> GetByIdAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);

            if (data is null)
                throw new NotFoundException<Value>();

            return _mapper.Map<ValueGetAllDto>(data);
        }

        public async Task<Value> UpdateAsync(int id, ValueUpdateDto dto)
        {
            var data = await _repo.GetByIdAsync(id);

            if (data is null)
                throw new NotFoundException<Value>();

            _mapper.Map(dto, data);

            await _repo.SaveAsync();

            return data;
        }
    }
}