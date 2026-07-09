using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SMConsulting.BL.DTOs.Applyment;
using SMConsulting.BL.Exceptions;
using SMConsulting.BL.Services.Abstracts;
using SMConsulting.Core.Entities;
using SMConsulting.Core.Repositories;
using SMConsulting.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Services.Implements
{
    public class ApplymentService(IApplymentRepository _repo,IMapper _mapper) : IApplymentService
    {
        public async Task<Applyment> CreateAsync(ApplymentCreateDto dto)
        {
            Applyment applyment = _mapper.Map<Applyment>(dto);
            await _repo.AddAsync(applyment);
            await _repo.SaveAsync();
            return applyment;
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<Applyment>();
        await _repo.RemoveAsync(id);
            await _repo.SaveAsync();
        }

        public async Task<IEnumerable<ApplymentGetAllDto>> GetAllAsync()
        {
            var datas = await _repo.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<ApplymentGetAllDto>>(datas);
        }

        public async Task<ApplymentGetAllDto> GetByIdAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<Applyment>();
            return _mapper.Map<ApplymentGetAllDto> (data);
        }


        public async Task<IEnumerable<ApplymentGetAllDto>> GetWithPagination(int page, int take)
        {
            var applyments = await _repo
                .GetWithPagination(page, take)
                .ToListAsync();

            return _mapper.Map<IEnumerable<ApplymentGetAllDto>>(applyments);
        }

        public async Task<ApplymentGetAllDto> UpdateAsync(int id,ApplymentUpdateDto dto)
        {
            var data = await _repo.GetByIdAsync(id);
                if (data is null)
                throw new NotFoundException<Applyment>();
            _mapper.Map(dto, data);
            await _repo.SaveAsync();
            return _mapper.Map<ApplymentGetAllDto>(data);
        }
    }
}
