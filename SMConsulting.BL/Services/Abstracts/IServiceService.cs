using SMConsulting.BL.DTOs.Blog;
using SMConsulting.BL.DTOs.Services;
using SMConsulting.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Services.Abstracts
{
    public interface IServiceService
    {
        Task<Service> CreateAsync(ServiceCreateDto dto);
        Task<ServiceGetAllDto> UpdateAsync(int id, ServiceUpdateDto dto);
        Task<IEnumerable<ServiceGetAllDto>> GetWithPagination(int page, int take);
        Task<IEnumerable<ServiceGetAllDto>> GetAllAsync();
        Task<ServiceGetAllDto> GetByIdAsync(int id);
        Task DeleteAsync(int id);
    }
}
