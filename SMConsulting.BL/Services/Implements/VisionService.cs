using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SMConsulting.BL.DTOs.Vision;
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
    public class VisionService(IVisionRepository _repo, IMapper _mapper) : IVisionService
    {
        public async Task<Vision> CreateAsync(VisionCreateDto dto)
        {
            Vision vs = _mapper.Map<Vision>(dto);
            await _repo.AddAsync(vs);
            await _repo.SaveAsync();
            return vs;
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<Vision>();
            await _repo.RemoveAsync(id);
            await _repo.SaveAsync();
        }

        public async Task<IEnumerable<VisionGetAllDto>> GetAllAsync()
        {
            var datas = await _repo.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<VisionGetAllDto>>(datas);
        }

        public async Task<VisionGetAllDto> GetByIdAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<Vision>();
            return _mapper.Map<VisionGetAllDto>(data);

        }

        public async Task<Vision> UpdateAsync(int id, VisionUpdateDto dto)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<Vision>();
            _mapper.Map(dto, data);
            await _repo.SaveAsync();
            return data;
        }
    }
}
