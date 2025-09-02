using GNW_Bazaar.Core.Interface;
using GNW_Bazaar.Core.Interface.Services;
using GNW_Bazzar.Dto;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace GNW_Bazaar.Core.Services
{
    public class TokenService(IConfigurationSettings configuration) : ITokenService
    {
        public string GenerateAccessToken(UserDto userDto)
        {
            try
            {
                var claims = new[]
                {
                new Claim(JwtRegisteredClaimNames.Sub, userDto.Id.ToString()),
                new Claim(ClaimTypes.Name, userDto.Name),
                new Claim(JwtRegisteredClaimNames.Email, userDto.Email)
            };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.GetJwtDetails().SecurityKey));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddDays(Convert.ToInt32(configuration.GetJwtDetails().ExpiresInDays)),
                    signingCredentials: creds
                );

                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            catch (Exception ex)
            {
                throw new Exception("Error generating access token", ex);
            }
        }

        public RefreshTokenDto GenerateRefreshToken(long userId)
        {
            try
            {
                var randomNumber = new byte[32];
                using var rng = RandomNumberGenerator.Create();
                rng.GetBytes(randomNumber);
                var refreshTokenString = Convert.ToBase64String(randomNumber);

                var refreshToken = new RefreshTokenDto
                {
                    UserId = userId,
                    Token = refreshTokenString,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    ExpiryDate = DateTime.UtcNow.AddDays(7)
                };

                return refreshToken;
            }
            catch (Exception ex)
            {
                throw new Exception("Error generating refresh token", ex);
            }
        }
    }
}
