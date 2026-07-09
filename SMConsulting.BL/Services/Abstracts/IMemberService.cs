using SMConsulting.BL.DTOs.Member;
using SMConsulting.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Services.Abstracts
{
    public interface IMemberService
    {
        Task<Member> CreateAsync(MemberCreateDto dto);
        Task<Member> UpdateAsync(int id, MemberUpdateDto dto);
        Task<IEnumerable<MemberGetAllDto>> GetAllAsync();
        Task<MemberGetAllDto> GetByIdAsync(int id);
        Task DeleteAsync(int id);
    }
}
