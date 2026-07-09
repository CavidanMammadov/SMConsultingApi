using SMConsulting.BL.DTOs.Card;
using SMConsulting.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Services.Abstracts
{
    public interface ICardService
    {
        Task<Card> CreateAsync(CardCreateDto dto);
        Task<Card> UpdateAsync(int id, CardUpdateDto dto);
        Task DeleteAsync(int id);
        Task<IEnumerable<CardGetAllDto>> GetAllAsync();
        Task<CardGetAllDto> GetByIdAsync(int id);
    }
}
