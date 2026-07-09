using SMConsulting.BL.DTOs.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Services.Abstracts
{
    public interface IAuthService
    {
        Task<AuthResponseDto> LoginAsync(LoginDto dto);

        Task RegisterAsync(RegisterDto dto);
        Task<AuthResponseDto> RefreshAsync(string refreshToken);
        Task LogoutAsync(string refreshToken);
    }
}
