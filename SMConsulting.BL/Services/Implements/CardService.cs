using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SMConsulting.BL.DTOs.Card;
using SMConsulting.BL.Exceptions;
using SMConsulting.BL.ExternalServices.Abstracts;
using SMConsulting.BL.Services.Abstracts;
using SMConsulting.Core.Entities;
using SMConsulting.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Services.Implements
{
    public class CardService(ICardRepository _repo, IFileService _file, IMapper _mapper) : ICardService
    {
        public async Task<Card> CreateAsync(CardCreateDto dto)
        {
            string imageUrl = await _file.SaveImageAsync(dto.CardIcon, "Cards");
            try
            {
                var data = _mapper.Map<Card>(dto);
                data.CardIcon = imageUrl;
                await _repo.AddAsync(data);
                await _repo.SaveAsync();
                return data;
            }
            catch
            {
                await _file.DeleteImageAsync(imageUrl);
                throw;
            }
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<Card>();
            await _repo.RemoveAsync(id);
            await _file.DeleteImageAsync(data.CardIcon);
            await _repo.SaveAsync();

        }


        public async Task<IEnumerable<CardGetAllDto>> GetAllAsync()
        {
            var datas = await _repo.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<CardGetAllDto>>(datas);
        }

        public async Task<CardGetAllDto> GetByIdAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null) 
                throw new NotFoundException<Card>();
            return _mapper.Map<CardGetAllDto>(data);

        }

        public async Task<Card> UpdateAsync(int id, CardUpdateDto dto)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<Card>();
            string oldImageUrl = data.CardIcon;
            if(dto.CardIcon != null)
            {
                var imageUrl = await _file.SaveImageAsync(dto.CardIcon, "Cards");
                data.CardIcon = imageUrl;
                await _file.DeleteImageAsync(oldImageUrl);
            }
            _mapper.Map(dto, data);
            await _repo.SaveAsync();
             return data;   
        }

    }
}
