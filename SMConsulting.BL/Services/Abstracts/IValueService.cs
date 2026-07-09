using SMConsulting.BL.DTOs.Value;
using SMConsulting.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Services.Abstracts
{
    public interface IValueService
    {
        Task<Value> CreateAsync(ValueCreateDto dto);
        Task<Value> UpdateAsync(int id, ValueUpdateDto dto);
        Task<IEnumerable<ValueGetAllDto>> GetAllAsync();
        Task<ValueGetAllDto> GetByIdAsync(int id);
        Task DeleteAsync(int id);
    }
}
