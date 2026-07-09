using SMConsulting.BL.DTOs.Partner;
using SMConsulting.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Services.Abstracts
{
    public interface IPartnerService
    {
        Task<Partner> CreateAsync(PartnerCreateDto dto);
        Task<Partner> UpdateAsync(int id,PartnerUpdateDto dto);
        Task<IEnumerable<PartnerGetAllDto>> GetAllAsync();  
        Task<PartnerGetAllDto> GetByIdAsync(int id);
        Task DeleteAsync(int id);
    }
}
