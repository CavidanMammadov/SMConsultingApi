using SMConsulting.BL.DTOs.Hero;
using SMConsulting.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Services.Abstracts
{
    public interface IHeroService
    {
        Task<Hero> CreateAsync(HeroCreateDto dto);
        Task<Hero> UpdateAsync(int id,HeroUpdateDto dto);
        Task<IEnumerable<HeroGetAllDto>> GetAllAsync();
        Task<HeroGetAllDto> GetByIdAsync(int id);
        Task DeleteAsync (int id);
    }
}
