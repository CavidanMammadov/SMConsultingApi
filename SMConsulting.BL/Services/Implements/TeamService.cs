using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SMConsulting.BL.DTOs.Team;
using SMConsulting.BL.Exceptions;
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
    public class TeamService(ITeamRepository _repo, IMapper _mapper) : ITeamService
    {
        public async Task<Team> CreateAsync(TeamCreateDto dto)
        {
            Team team = _mapper.Map<Team>(dto);

            await _repo.AddAsync(team);
            await _repo.SaveAsync();

            return team;
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);

            if (data is null)
                throw new NotFoundException<Team>();

            await _repo.RemoveAsync(id);
            await _repo.SaveAsync();
        }

        public async Task<IEnumerable<TeamGetAllDto>> GetAllAsync()
        {
            var datas = await _repo.GetAll().ToListAsync();

            return _mapper.Map<IEnumerable<TeamGetAllDto>>(datas);
        }

        public async Task<TeamGetAllDto> GetByIdAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);

            if (data is null)
                throw new NotFoundException<Team>();

            return _mapper.Map<TeamGetAllDto>(data);
        }

        public async Task<Team> UpdateAsync(int id, TeamUpdateDto dto)
        {
            var data = await _repo.GetByIdAsync(id);

            if (data is null)
                throw new NotFoundException<Team>();

            _mapper.Map(dto, data);

            await _repo.SaveAsync();

            return data;
        }
    }
}