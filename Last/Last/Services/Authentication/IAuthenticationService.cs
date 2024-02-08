using Last.Client.Dtos.Api;
using Last.Client.Dtos.Login;

namespace Last.Services.Authentication
{
    public interface IAuthenticationService
    {
        public Task<ApiResponseDto<LoginResponseDto?>> Login(LoginRequestDto loginRequestDto);

        public Task<string> RefreshToken();
    }
}
