using SMConsulting.BL.DTOs.Difficulty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Services.Abstracts
{
    public interface IDifficultyService
    {
        Task<DifficultyGetAllDto> CreateAsync(DifficultyCreateDto dto);
        Task<DifficultyGetAllDto> UpdateAsync(int id, DifficultyUpdateDto dto);
        Task<IEnumerable<DifficultyGetAllDto>> GetAllAsync();
        Task<DifficultyGetAllDto> GetByIdAsync(int id);
        Task DeleteAsync(int id);
    }
}
