using SMConsulting.BL.DTOs.CardSpecifications;
using SMConsulting.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Services.Abstracts
{
    public interface ICardSpecificationService
    {
        Task<CardSpecification> CreateAsync(CardSpecificationCreateDto dto);
        Task<CardSpecification> UpdateAsync(int id, CardSpecificationUpdateDto dto);
        Task<IEnumerable<CardSpecificationGetAllDto>> GetAllAsync();
        Task<CardSpecificationGetAllDto> GetByIdAsync(int id);
        Task DeleteAsync(int id);
    }
}
