using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SMConsulting.BL.DTOs.CardSpecifications;
using SMConsulting.BL.Exceptions;
using SMConsulting.BL.ExternalServices.Abstracts;
using SMConsulting.BL.Services.Abstracts;
using SMConsulting.Core.Entities;
using SMConsulting.Core.Repositories;

namespace SMConsulting.BL.Services.Implements
{
    public class CardSpecificationService(
        ICardSpecificationRepository _repo,
        IFileService _file,
        IMapper _mapper) : ICardSpecificationService
    {
        public async Task<CardSpecification> CreateAsync(CardSpecificationCreateDto dto)
        {
            string iconUrl = null;

            try
            {
                if (dto.CardSpecificationIcon != null)
                {
                    iconUrl = await _file.SaveImageAsync(
                        dto.CardSpecificationIcon,
                        "CardSpecifications");
                }

                var data = _mapper.Map<CardSpecification>(dto);

                data.CardSpecificationIcon = iconUrl;

                await _repo.AddAsync(data);
                await _repo.SaveAsync();

                return data;
            }
            catch
            {
                if (iconUrl != null)
                {
                    await _file.DeleteImageAsync(iconUrl);
                }

                throw;
            }
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);

            if (data is null)
                throw new NotFoundException<CardSpecification>();

            await _repo.RemoveAsync(id);

            if (!string.IsNullOrEmpty(data.CardSpecificationIcon))
            {
                await _file.DeleteImageAsync(data.CardSpecificationIcon);
            }

            await _repo.SaveAsync();
        }

        public async Task<IEnumerable<CardSpecificationGetAllDto>> GetAllAsync()
        {
            var datas = await _repo.GetAll().ToListAsync();

            return _mapper.Map<IEnumerable<CardSpecificationGetAllDto>>(datas);
        }

        public async Task<CardSpecificationGetAllDto> GetByIdAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);

            if (data is null)
                throw new NotFoundException<CardSpecification>();

            return _mapper.Map<CardSpecificationGetAllDto>(data);
        }

        public async Task<CardSpecification> UpdateAsync(
            int id,
            CardSpecificationUpdateDto dto)
        {
            var data = await _repo.GetByIdAsync(id);

            if (data is null)
                throw new NotFoundException<CardSpecification>();

            if (dto.CardSpecificationIcon != null)
            {
                string newIcon = await _file.SaveImageAsync(
                    dto.CardSpecificationIcon,
                    "CardSpecifications");

                if (!string.IsNullOrEmpty(data.CardSpecificationIcon))
                {
                    await _file.DeleteImageAsync(data.CardSpecificationIcon);
                }

                data.CardSpecificationIcon = newIcon;
            }

            _mapper.Map(dto, data);

            await _repo.SaveAsync();

            return data;
        }
    }
}