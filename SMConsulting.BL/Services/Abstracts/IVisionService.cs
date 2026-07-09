using SMConsulting.BL.DTOs.Vision;
using SMConsulting.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Services.Abstracts
{
    public interface IVisionService
    {
        Task<Vision> CreateAsync(VisionCreateDto dto);
        Task<Vision> UpdateAsync(int id, VisionUpdateDto dto);
        Task DeleteAsync(int id);
        Task<IEnumerable<VisionGetAllDto>> GetAllAsync();
        Task<VisionGetAllDto> GetByIdAsync(int id);


    }
}
