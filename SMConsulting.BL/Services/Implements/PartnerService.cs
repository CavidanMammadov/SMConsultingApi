using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SMConsulting.BL.DTOs.Partner;
using SMConsulting.BL.Exceptions;
using SMConsulting.BL.ExternalServices.Abstracts;
using SMConsulting.BL.Services.Abstracts;
using SMConsulting.Core.Entities;
using SMConsulting.Core.Repositories;
using System.Xml.Serialization;

namespace SMConsulting.BL.Services.Implements
{
    public class PartnerService(IPartnerRepository _repo , IFileService _file, IMapper _mapper) : IPartnerService
    {
        public async Task<Partner> CreateAsync(PartnerCreateDto dto)
        {
            string imageUrl = null;
            try
            {
                if(dto.PartnerImage != null)
                {
                    imageUrl = await _file.SaveImageAsync(dto.PartnerImage, "Partners");
                }
                var data =  _mapper.Map<Partner>(dto);
                data.PartnerImage = imageUrl;
                await _repo.AddAsync(data);
                await _repo.SaveAsync();
                return data;
            }
            catch 
            {
                if (imageUrl != null) {
                    await _file.DeleteImageAsync(imageUrl);
                }
                throw;
            }
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<Partner>();
            await _repo.RemoveAsync(id);
            await _file.DeleteImageAsync(data.PartnerImage);
            await _repo.SaveAsync();
        }

        public async Task<IEnumerable<PartnerGetAllDto>> GetAllAsync()
        {
            var datas = await _repo.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<PartnerGetAllDto>>(datas);
        }

        public async Task<PartnerGetAllDto> GetByIdAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<Partner>();
            return _mapper.Map<PartnerGetAllDto>(data);
        }

        public async Task<Partner> UpdateAsync(int id, PartnerUpdateDto dto)
        {
            var data = await _repo.GetByIdAsync(id);
            if(data is null)
                throw new NotFoundException<Partner>();
            if(dto.PartnerImage != null)
            {
                string newImage = await _file.SaveImageAsync(dto.PartnerImage, "Partners");

                if (!string.IsNullOrEmpty(data.PartnerImage))
                    await _file.DeleteImageAsync(data.PartnerImage);

                data.PartnerImage = newImage;
            }
            else
            {
                await _file.DeleteImageAsync(data.PartnerImage);
                data.PartnerImage = null;
            }

            _mapper.Map(dto, data);

            await _repo.SaveAsync();

            return data;
        }
    }
}
