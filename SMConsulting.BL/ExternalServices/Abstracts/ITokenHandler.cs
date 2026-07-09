using SMConsulting.BL.DTOs.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.ExternalServices.Abstracts
{
    public interface ITokenHandler
    {
        TokenResult CreateAccessToken(JwtDto dto);
        string CreateRefreshToken();
    }
}
