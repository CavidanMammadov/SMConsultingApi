using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SMConsulting.BL.DTOs.Blog;
using SMConsulting.BL.DTOs.Services;
using SMConsulting.BL.Exceptions;
using SMConsulting.BL.Services.Abstracts;
using SMConsulting.Core.Entities;
using SMConsulting.Core.Repositories;

namespace SMConsulting.BL.Services.Implements
{
    public class ServiceService(IServiceRepository _repo, IMapper _mapper) : IServiceService
    {
        public async Task<Service> CreateAsync(ServiceCreateDto dto)
        {
            Service service = _mapper.Map<Service>(dto);

            await _repo.AddAsync(service);
            await _repo.SaveAsync();

            return service;
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);

            if (data is null)
                throw new NotFoundException<Service>();

            await _repo.RemoveAsync(id);
            await _repo.SaveAsync();
        }

        public async Task<IEnumerable<ServiceGetAllDto>> GetAllAsync()
        {
            var datas = await _repo.GetAll().ToListAsync();

            return _mapper.Map<IEnumerable<ServiceGetAllDto>>(datas);
        }

        public async Task<ServiceGetAllDto> GetByIdAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);

            if (data is null)
                throw new NotFoundException<Service>();

            return _mapper.Map<ServiceGetAllDto>(data);
        }

        public async Task<IEnumerable<ServiceGetAllDto>> GetWithPagination(int page, int take)
        {
            var datas = await _repo
                      .GetWithPagination(page, take)
                         .ToListAsync();
            return _mapper.Map<IEnumerable<ServiceGetAllDto>>(datas);
        }

        public async Task<ServiceGetAllDto> UpdateAsync(int id, ServiceUpdateDto dto)
        {
            var data = await _repo.GetByIdAsync(id);

            if (data is null)
                throw new NotFoundException<Service>();

            _mapper.Map(dto, data);

            await _repo.SaveAsync();

            return _mapper.Map<ServiceGetAllDto>(data);
        }
    }
}