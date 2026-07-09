using SMConsulting.BL.DTOs.Team;
using SMConsulting.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Services.Abstracts
{
    public interface ITeamService
    {
        Task<Team> CreateAsync(TeamCreateDto dto);
        Task<Team> UpdateAsync(int id, TeamUpdateDto dto);
        Task<IEnumerable<TeamGetAllDto>> GetAllAsync();
        Task<TeamGetAllDto> GetByIdAsync(int id);
        Task DeleteAsync(int id);
    }
}
