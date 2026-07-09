using SMConsulting.BL.DTOs.Applyment;
using SMConsulting.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Services.Abstracts
{
    public interface IApplymentService
    {
        Task<Applyment> CreateAsync(ApplymentCreateDto dto);
        Task<ApplymentGetAllDto> UpdateAsync(int id,ApplymentUpdateDto dto);
        Task<IEnumerable<ApplymentGetAllDto>> GetWithPagination(int page, int take);
        Task<IEnumerable<ApplymentGetAllDto>> GetAllAsync();
        Task<ApplymentGetAllDto> GetByIdAsync(int id);
        Task DeleteAsync (int id);
    }
}
