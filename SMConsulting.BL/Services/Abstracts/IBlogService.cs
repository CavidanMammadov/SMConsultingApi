using SMConsulting.BL.DTOs.Applyment;
using SMConsulting.BL.DTOs.Blog;
using SMConsulting.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Services.Abstracts
{
    public interface IBlogService
    {
        Task<Blog> CreateAsync(BlogCreateDto dto);
        Task<Blog> UpdateAsync(int id, BlogUpdateDto dto);
        Task<IEnumerable<BlogGetAllDto>> GetWithPagination(int page, int take);
        Task<IEnumerable<BlogGetAllDto>> GetAllAsync();
        Task<BlogGetAllDto> GetByIdAsync(int id);
        Task DeleteAsync(int id);
    }
}
