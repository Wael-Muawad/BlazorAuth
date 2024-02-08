using Blazored.SessionStorage;
using Last.Client.Dtos.Api;
using Last.Client.Dtos.Login;
using System.Net.Http.Json;
using System.Text.Json;

namespace Last.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _serializerOptions;
        private readonly ISessionStorageService _sessionStorage;

        public AuthenticationService(HttpClient httpClient, ISessionStorageService sessionStorage)
        {
            _httpClient = httpClient;
            _serializerOptions = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
            _sessionStorage = sessionStorage;
        }

        public async Task<ApiResponseDto<LoginResponseDto?>> Login(LoginRequestDto loginRequestDto)
        {
            await _sessionStorage.SetItemAsync<string>("gg", "dehellow");
            var apiResponse = new ApiResponseDto<LoginResponseDto?>();
            var errorsDic = new Dictionary<string, List<string>>();
            try
            {
                var response = await _httpClient.PostAsJsonAsync<LoginRequestDto>("v1/auth/login", loginRequestDto, _serializerOptions);
                
                if (!response.IsSuccessStatusCode)
                {
                    var responseError = await response.Content.ReadFromJsonAsync<ErrorResponseDto>(_serializerOptions);
                   
                    if (responseError.Errors == null)
                        errorsDic.Add(responseError.Title, new List<string> { responseError.Detail });
                    else
                        errorsDic = responseError.Errors;

                    apiResponse.SetFailureWithErrorList(errorsDic);
                }

                else
                {
                    var responseBody = await response.Content.ReadFromJsonAsync<LoginResponseDto>(_serializerOptions);
                    apiResponse.SetSuccessWithPayload(responseBody);
                }
            }
            catch (Exception e)
            {                
                errorsDic.Add("error", new List<string> { e.Message });
                apiResponse.SetFailureWithErrorList(errorsDic);
            }

            return apiResponse;
        }

        public Task<string> RefreshToken()
        {
            throw new NotImplementedException();
        }
    }
}
