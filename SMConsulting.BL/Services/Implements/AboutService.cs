using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using SMConsulting.BL.DTOs.About;
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
    public class AboutService(IAboutRepository _repo, IMapper _mapper) : IAboutService
    {
        public async Task<About> CreateAsync(AboutCreateDto dto)
        {
            About about = _mapper.Map<About>(dto);
            await _repo.AddAsync(about);
            await _repo.SaveAsync();
            return about;
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<About>();
            await _repo.RemoveAsync(id);
            await _repo.SaveAsync();
        }

        public async Task<IEnumerable<AboutGetAllDto>> GetAllAsync()
        {
            var datas = await _repo.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<AboutGetAllDto>>(datas);

        }

        public async Task<AboutGetAllDto> GetByIdAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);
            if(data is null)
                throw new NotFoundException<About>();
            return _mapper.Map<AboutGetAllDto>(data);
        }

        public async Task<About> UpdateAsync(int id, AboutUpdateDto dto)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<About>();
            _mapper.Map(dto, data);
            await _repo.SaveAsync();
            return data;

        }
    }
}
