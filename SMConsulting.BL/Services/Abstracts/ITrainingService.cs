using SMConsulting.BL.DTOs.CardSpecifications;
using SMConsulting.BL.DTOs.Training;
using SMConsulting.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Services.Abstracts
{
    public interface ITrainingService
    {
        Task<Training> CreateAsync(TrainingCreateDto dto);
        Task<Training> UpdateAsync(int id, TrainingUpdateDto dto);
        Task<IEnumerable<TrainingGetAllDto>> GetAllAsync();
        Task<TrainingGetAllDto> GetByIdAsync(int id);
        Task DeleteAsync(int id);
    }
}
