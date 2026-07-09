using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SMConsulting.BL.DTOs.Auth;
using SMConsulting.BL.Exceptions;
using SMConsulting.BL.Exceptions.Common;
using SMConsulting.BL.ExternalServices.Abstracts;
using SMConsulting.BL.Helpers;
using SMConsulting.BL.Services.Abstracts;
using SMConsulting.Core.Entities;
using SMConsulting.Core.Repositories;

namespace SMConsulting.BL.Services.Implements
{
    public class AuthService(IUserRepository _repo, ITokenHandler _tokenHandler,IMapper _mapper, IRefreshTokenRepository _refreshTokenRepo) : IAuthService
    {

        public async Task<AuthResponseDto> LoginAsync(LoginDto dto)
        {
            var user = await _repo.GetAll()
                .Where(x => x.UserUserName == dto.UserNameOrEmail
                         || x.UserEmail == dto.UserNameOrEmail)
                .FirstOrDefaultAsync();

            if (user is null)
                throw new NotFoundException<User>();

            bool isValid = HashHelper.VerifyHashedPassword(
                user.UserPasswordHash, dto.Password);

            if (!isValid)
                throw new Exception("Username/email or password is incorrect");

            var access = _tokenHandler.CreateAccessToken(new JwtDto
            {
                FullName = user.UserFullName,
                Email = user.UserEmail,
                Role = user.UserRole,
                UserName = user.UserUserName
            });

            var refreshToken = _tokenHandler.CreateRefreshToken();
            var refreshExpire = DateTime.UtcNow.AddDays(7);

            await _refreshTokenRepo.AddAsync(new RefreshToken
            {
                RefreshTokenToken = refreshToken,
                RefreshTokenUserId = user.UserId,
                RefreshTokenExpireTime = refreshExpire,
                RefreshTokenCreatedAt = DateTime.UtcNow
            });

            return new AuthResponseDto
            {
                AccessToken = access.Token,
                AccessTokenExpireDate = access.ExpireDate,
                RefreshToken = refreshToken,
                RefreshTokenExpireDate = refreshExpire
            };
        }






        public async Task LogoutAsync(string refreshToken)
        {
            var token = await _refreshTokenRepo.GetByTokenAsync(refreshToken);

            if (token is null)
                return;

            token.RefreshTokenIsRevoked = true;

            await _refreshTokenRepo.UpdateAsync(token);
        }







        public async Task<AuthResponseDto> RefreshAsync(string refreshToken)
        {
            var token = await _refreshTokenRepo.GetByTokenAsync(refreshToken);

            if (token is null || token.RefreshTokenExpireTime < DateTime.UtcNow)
                throw new Exception("Invalid refresh token");

            if (token.RefreshTokenIsRevoked)
                throw new Exception("Token revoked");

            var user = await _repo.GetByIdAsync(token.RefreshTokenUserId);

            var access = _tokenHandler.CreateAccessToken(new JwtDto
            {
                FullName = user.UserFullName,
                Email = user.UserEmail,
                Role = user.UserRole,
                UserName = user.UserUserName
            });

            var newRefresh = _tokenHandler.CreateRefreshToken();

            token.RefreshTokenIsRevoked = true;
            await _refreshTokenRepo.UpdateAsync(token);

            var newExpire = DateTime.UtcNow.AddDays(7);

            await _refreshTokenRepo.AddAsync(new RefreshToken
            {
                RefreshTokenToken = newRefresh,
                RefreshTokenUserId = user.UserId,
                RefreshTokenExpireTime = newExpire,
                RefreshTokenCreatedAt = DateTime.UtcNow
            });

            return new AuthResponseDto
            {
                AccessToken = access.Token,
                AccessTokenExpireDate = access.ExpireDate,
                RefreshToken = newRefresh,
                RefreshTokenExpireDate = newExpire
            };
        }

        public async Task RegisterAsync(RegisterDto dto)
        {

            var user = await _repo.GetAll().Where(x => x.UserUserName == dto.UserUserName
            || x.UserEmail == dto.UserEmail).FirstOrDefaultAsync();
            if (user != null)
            {
                if (user.UserEmail == dto.UserEmail)
                {
                    throw new ExistException("Email already taken");
                }
                else
                {
                    throw new ExistException("Username already taken");
                }
            }
            user = _mapper.Map<User>(dto);
            await _repo.AddAsync(user);
            await _repo.SaveAsync();

        }
    }
}