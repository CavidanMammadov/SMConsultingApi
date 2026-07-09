using SMConsulting.BL.DTOs.SocialMedia;
using SMConsulting.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Services.Abstracts
{
    public interface ISocialMediaService
    {
        Task<SocialMedia> CreateAsync(SocialMediaCreateDto dto);
        Task<SocialMedia> UpdateAsync(int id, SocialMediaUpdateDto dto);
        Task DeleteAsync(int id);
        Task<IEnumerable<SocialMediaGetAllDto>> GetAllAsync();
        Task<SocialMediaGetAllDto> GetByIdAsync(int id);

    }
}
