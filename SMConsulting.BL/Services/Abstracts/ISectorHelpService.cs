using SMConsulting.BL.DTOs.About;
using SMConsulting.BL.DTOs.SectorHelp;
using SMConsulting.Core;
using SMConsulting.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Services.Abstracts
{
    public interface ISectorHelpService
    {
        Task<SectorHelp> CreateAsync(SectorHelpCreateDto dto);
        Task<SectorHelp> UpdateAsync(int id, SectorHelpUpdateDto dto);
        Task<IEnumerable<SectorHelpGetAllDto>> GetAllAsync();
        Task<SectorHelpGetAllDto> GetByIdAsync(int id);
        Task DeleteAsync(int id);
    }
}
