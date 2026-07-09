using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SMConsulting.BL.DTOs.Sector;
using SMConsulting.BL.Exceptions;
using SMConsulting.BL.Services.Abstracts;
using SMConsulting.Core.Entities;
using SMConsulting.Core.Repositories;

namespace SMConsulting.BL.Services.Implements
{
    public class SectorService(ISectorRepository _repo, IMapper _mapper) : ISectorService
    {
        public async Task<Sector> CreateAsync(SectorCreateDto dto)
        {
            Sector sector = _mapper.Map<Sector>(dto);

            await _repo.AddAsync(sector);
            await _repo.SaveAsync();

            return sector;
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);

            if (data is null)
                throw new NotFoundException<Sector>();

            await _repo.RemoveAsync(id);
            await _repo.SaveAsync();
        }

        public async Task<IEnumerable<SectorGetAllDto>> GetAllAsync()
        {
            var datas = await _repo.GetAll()
    .Include(x => x.SectorHelps)
    .ThenInclude(x=>x.Difficulties)
    .ToListAsync();

            return _mapper.Map<IEnumerable<SectorGetAllDto>>(datas);
        }

        public async Task<SectorGetAllDto> GetByIdAsync(int id)
        {
            var data = await _repo.GetAll()
        .Include(x => x.SectorHelps)
        .ThenInclude(x=>x.Difficulties)
        .FirstOrDefaultAsync(x => x.SectorId == id);

            if (data is null)
                throw new NotFoundException<Sector>();

            return _mapper.Map<SectorGetAllDto>(data);
        }

        public async Task<Sector> UpdateAsync(int id, SectorUpdateDto dto)
        {
            var data = await _repo.GetByIdAsync(id);

            if (data is null)
                throw new NotFoundException<Sector>();

            _mapper.Map(dto, data);

            await _repo.SaveAsync();

            return data;
        }
    }
}