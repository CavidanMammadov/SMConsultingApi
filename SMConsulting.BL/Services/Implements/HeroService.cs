using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SMConsulting.BL.DTOs.Hero;
using SMConsulting.BL.Exceptions;
using SMConsulting.BL.ExternalServices.Abstracts;
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
    public class HeroService(IHeroRepository _repo, IFileService _file, IMapper _mapper) : IHeroService
    {
        public async Task<Hero> CreateAsync(HeroCreateDto dto)
        {
            string imageUrl = await _file.SaveImageAsync(dto.HeroImage, "Heros");
            try
            {
                var data = _mapper.Map<Hero>(dto);
                data.HeroImageUrl = imageUrl;
                await _repo.AddAsync(data);
                await _repo.SaveAsync();
                return data;

            }
            catch
            {
                await _file.DeleteImageAsync(imageUrl);
                throw;
            }
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<Hero>();
            await _repo.RemoveAsync(id);
            await _file.DeleteImageAsync(data.HeroImageUrl);
            await _repo.SaveAsync();
        }

        public async Task<IEnumerable<HeroGetAllDto>> GetAllAsync()
        {
            var datas = await _repo.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<HeroGetAllDto>>(datas);

        }

        public async Task<HeroGetAllDto> GetByIdAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<Hero>();
            return _mapper.Map<HeroGetAllDto>(data);

        }

        public async Task<Hero> UpdateAsync(int id,HeroUpdateDto dto)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<Hero>();
            string oldImageUrl = data.HeroImageUrl;
            if(dto.HeroImage != null)
            {
                var  imageUrl = await _file.SaveImageAsync(dto.HeroImage, "Heros");
                data.HeroImageUrl = imageUrl;
                await _file.DeleteImageAsync(oldImageUrl);
            }
            _mapper.Map(dto, data);
            await _repo.SaveAsync();
            return data;
        } 
    }
}
