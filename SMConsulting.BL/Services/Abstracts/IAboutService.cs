using SMConsulting.BL.DTOs.About;
using SMConsulting.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Services.Abstracts
{
    public interface IAboutService
    {
        Task<About> CreateAsync(AboutCreateDto dto);
        Task<About> UpdateAsync(int id, AboutUpdateDto dto);
        Task<IEnumerable<AboutGetAllDto>> GetAllAsync();
        Task<AboutGetAllDto> GetByIdAsync(int id);  
        Task DeleteAsync(int id);
    }
}
