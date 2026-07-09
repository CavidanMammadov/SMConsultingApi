using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SMConsulting.BL.DTOs.Auth;
using SMConsulting.BL.ExternalServices.Abstracts;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.ExternalServices.Implements
{
    public class TokenHandler(IConfiguration _config) : ITokenHandler
    {
        public TokenResult CreateAccessToken(JwtDto dto)
        {
            string issuer = _config["Jwt:Issuer"]!;
            string audience = _config["Jwt:Audience"]!;
            string secretKey = _config["Jwt:SecretKey"]!;

            var expire = DateTime.UtcNow.AddMinutes(15);

            List<Claim> claims = [
                new Claim(ClaimTypes.Name, dto.UserName),
        new Claim(ClaimTypes.Email, dto.Email),
        new Claim(ClaimTypes.Role, dto.Role.ToString()),
        new Claim("Fullname", dto.FullName)
            ];

            SymmetricSecurityKey key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(secretKey));

            SigningCredentials cred = new SigningCredentials(
                key, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken jwt = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                notBefore: DateTime.UtcNow,
                expires: expire,
                signingCredentials: cred
            );

            return new TokenResult
            {
                Token = new JwtSecurityTokenHandler().WriteToken(jwt),
                ExpireDate = expire
            };
        }
        public string CreateRefreshToken()
        {
            return Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));
        }

    }
}
