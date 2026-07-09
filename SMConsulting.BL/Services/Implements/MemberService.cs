using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SMConsulting.BL.DTOs.Member;
using SMConsulting.BL.Exceptions;
using SMConsulting.BL.ExternalServices.Abstracts;
using SMConsulting.BL.Services.Abstracts;
using SMConsulting.Core.Entities;
using SMConsulting.Core.Repositories;

namespace SMConsulting.BL.Services.Implements
{
    public class MemberService(IMemberRepository _repo, IFileService _file, IMapper _mapper) : IMemberService
    {
        public async Task<Member> CreateAsync(MemberCreateDto dto)
        {
            string imageUrl = null;

            if (dto.MemberImage != null && dto.MemberImage.Length > 0)
            {
                imageUrl = await _file.SaveImageAsync(dto.MemberImage, "Members");
            }

            try
            {
                var data = _mapper.Map<Member>(dto);
                data.MemberImage = imageUrl;

                await _repo.AddAsync(data);
                await _repo.SaveAsync();

                return data;
            }
            catch
            {
                if (imageUrl != null)
                    await _file.DeleteImageAsync(imageUrl);
                throw;
            }
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);

            if (data is null)
                throw new NotFoundException<Member>();

            await _repo.RemoveAsync(id);
            await _file.DeleteImageAsync(data.MemberImage);
            await _repo.SaveAsync();
        }

        public async Task<IEnumerable<MemberGetAllDto>> GetAllAsync()
        {
            var datas = await _repo.GetAll().ToListAsync();

            return _mapper.Map<IEnumerable<MemberGetAllDto>>(datas);
        }

        public async Task<MemberGetAllDto> GetByIdAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);

            if (data is null)
                throw new NotFoundException<Member>();

            return _mapper.Map<MemberGetAllDto>(data);
        }

        public async Task<Member> UpdateAsync(int id, MemberUpdateDto dto)
        {
            var data = await _repo.GetByIdAsync(id);

            if (data is null)
                throw new NotFoundException<Member>();

            string oldImageUrl = data.MemberImage;

            if (dto.MemberImage != null)
            {
                string imageUrl = await _file.SaveImageAsync(dto.MemberImage, "Members");

                data.MemberImage = imageUrl;

                await _file.DeleteImageAsync(oldImageUrl);
            }

            _mapper.Map(dto, data);

            await _repo.SaveAsync();

            return data;
        }
    }
}