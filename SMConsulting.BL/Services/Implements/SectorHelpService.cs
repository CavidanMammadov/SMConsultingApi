using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SMConsulting.BL.DTOs.SectorHelp;
using SMConsulting.BL.Exceptions;
using SMConsulting.BL.Services.Abstracts;
using SMConsulting.Core;
using SMConsulting.Core.Entities;
using SMConsulting.Core.Repositories;

namespace SMConsulting.BL.Services.Implements
{
    public class SectorHelpService(ISectorHelpRepository _helprepo, ISectorRepository _screpo, IMapper _mapper) : ISectorHelpService
    {
        public async Task<SectorHelp> CreateAsync(SectorHelpCreateDto dto)
        {
            var sector = await _screpo.GetByIdAsync(dto.SectorHelpSectorId);

            if (sector == null)
                throw new Exception("Sector tapılmadı");

            var entity = _mapper.Map<SectorHelp>(dto);

            await _helprepo.AddAsync(entity);
            await _helprepo.SaveAsync();

            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _helprepo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<SectorHelp>();
            await _helprepo.RemoveAsync(id);
            await _helprepo.SaveAsync();
        }

        public async Task<IEnumerable<SectorHelpGetAllDto>> GetAllAsync()
        {
            var datas = await _helprepo.GetAll()
    .Include(x => x.Difficulties)
    .ToListAsync();
            return _mapper.Map<IEnumerable<SectorHelpGetAllDto>>(datas);

        }

        public async Task<SectorHelpGetAllDto> GetByIdAsync(int id)
        {
            var data = await _helprepo.GetAll()
        .Include(x => x.Difficulties)
        .FirstOrDefaultAsync(x => x.SectorHelpId == id);
            if (data is null)
                throw new NotFoundException<SectorHelp>();
            return _mapper.Map<SectorHelpGetAllDto>(data);
        }

        public async Task<SectorHelp> UpdateAsync(int id, SectorHelpUpdateDto dto)
        {
            var data = await _helprepo.GetByIdAsync(id);

            if (data == null)
                throw new NotFoundException<SectorHelp>();

            var sector = await _screpo.GetByIdAsync(dto.SectorHelpSectorId);

            if (sector == null)
                throw new NotFoundException<Sector>();

            _mapper.Map(dto, data);

            await _helprepo.SaveAsync();

            return data;
        }
    }
}
