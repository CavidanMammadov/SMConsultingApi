using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SMConsulting.BL.DTOs.Difficulty;
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
    public class DifficultyService(IDifficultyRepository _repo, ISectorHelpRepository _screpo, IMapper _mapper) : IDifficultyService
    {
        public async Task<DifficultyGetAllDto> CreateAsync(DifficultyCreateDto dto)
        {
            var sector = await _screpo.GetByIdAsync(dto.DifficultSectorHelpId);

            if (sector == null)
                throw new Exception("SectorHelp tapılmadı");

            var entity = _mapper.Map<Difficulty>(dto);

            await _repo.AddAsync(entity);
            await _repo.SaveAsync();

            return _mapper.Map<DifficultyGetAllDto>(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<Difficulty>();
            await _repo.RemoveAsync(id);
            await   _repo.SaveAsync();
        }

        public async Task<IEnumerable<DifficultyGetAllDto>> GetAllAsync()
        {
            var data = await _repo.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<DifficultyGetAllDto>>(data);
        }

        public async Task<DifficultyGetAllDto> GetByIdAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<Difficulty>();
            return _mapper.Map<DifficultyGetAllDto>(data);
        }

        public async Task<DifficultyGetAllDto> UpdateAsync(int id, DifficultyUpdateDto dto)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<Difficulty>();
            var scHelp = await _screpo.GetByIdAsync(dto.DifficultSectorHelpId);
            if(scHelp is null)
                throw new NotFoundException<SectorHelp>();
            _mapper.Map(dto, data);
            await _repo.SaveAsync();
            return _mapper.Map<DifficultyGetAllDto>(data);
        }
    }
}
