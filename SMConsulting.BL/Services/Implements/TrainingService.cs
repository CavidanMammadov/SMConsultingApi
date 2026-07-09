using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SMConsulting.BL.DTOs.Training;
using SMConsulting.BL.Exceptions;
using SMConsulting.BL.Services.Abstracts;
using SMConsulting.Core.Entities;
using SMConsulting.Core.Repositories;

namespace SMConsulting.BL.Services.Implements
{
    public class TrainingService(ITrainingRepository _repo, IMapper _mapper) : ITrainingService
    {
        public async Task<Training> CreateAsync(TrainingCreateDto dto)
        {
            Training training = _mapper.Map<Training>(dto);
            await _repo.AddAsync(training);
            await _repo.SaveAsync();
            return training;
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<Training>();
            await _repo.RemoveAsync(id);
            await _repo.SaveAsync();

        }

        public async Task<IEnumerable<TrainingGetAllDto>> GetAllAsync()
        {
            var datas = await _repo.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<TrainingGetAllDto>>(datas);
        }

        public async Task<TrainingGetAllDto> GetByIdAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<Training>();
            return _mapper.Map<TrainingGetAllDto>(data);
        }

        public async Task<Training> UpdateAsync(int id, TrainingUpdateDto dto)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<Training>();
            _mapper.Map(dto, data);
            await _repo.SaveAsync();
            return data;
        }
    }
}
