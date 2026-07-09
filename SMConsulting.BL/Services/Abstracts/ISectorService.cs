using SMConsulting.BL.DTOs.Blog;
using SMConsulting.BL.DTOs.Sector;
using SMConsulting.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Services.Abstracts
{
    public interface ISectorService
    {
        Task<Sector> CreateAsync(SectorCreateDto dto);
        Task<Sector> UpdateAsync(int id, SectorUpdateDto dto);
        Task<IEnumerable<SectorGetAllDto>> GetAllAsync();
        Task<SectorGetAllDto> GetByIdAsync(int id);
        Task DeleteAsync(int id);
    }
}
