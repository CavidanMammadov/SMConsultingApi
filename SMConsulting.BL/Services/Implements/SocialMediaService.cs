using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SMConsulting.BL.DTOs.SocialMedia;
using SMConsulting.BL.Exceptions;
using SMConsulting.BL.Services.Abstracts;
using SMConsulting.Core.Entities;
using SMConsulting.Core.Repositories;

namespace SMConsulting.BL.Services.Implements
{
    public class SocialMediaService(ISocialMediaRepository _repo, IMapper _mapper) : ISocialMediaService
    {
        public async Task<SocialMedia> CreateAsync(SocialMediaCreateDto dto)
        {
            SocialMedia sc = _mapper.Map<SocialMedia>(dto);
            await _repo.AddAsync(sc);
            await _repo.SaveAsync();
            return sc;
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<SocialMedia>();
            await _repo.RemoveAsync(id);
            await _repo.SaveAsync();
        }

        public async Task<IEnumerable<SocialMediaGetAllDto>> GetAllAsync()
        {
            var datas = await _repo.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<SocialMediaGetAllDto>>(datas);

        }

        public async Task<SocialMediaGetAllDto> GetByIdAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<SocialMedia>();
            return _mapper.Map<SocialMediaGetAllDto>(data);
        }

        public async Task<SocialMedia> UpdateAsync(int id, SocialMediaUpdateDto dto)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<SocialMedia>();
            _mapper.Map(dto, data);
            await _repo.SaveAsync();
            return data;
        }
    }
}
