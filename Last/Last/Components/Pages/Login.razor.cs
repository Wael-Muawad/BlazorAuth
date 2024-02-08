using Last.Client.Dtos.Login;
using Last.Services.Authentication;
using Microsoft.AspNetCore.Components;

namespace Last.Components.Pages
{
    public partial class Login
    {
        [SupplyParameterFromForm]
        private LoginRequestDto _loginRequestDto { get; set; } = new();


        //private LoginRequestDto _loginRequestDto = new();

        [Inject]
        private IAuthenticationService _authenticationService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public bool ShowAuthError { get; set; }
        public bool SuccessfulLogin { get; set; } = false;
        public Dictionary<string, List<string>> Errors { get; set; }


        protected override async Task OnInitializedAsync()
        {
            //ShowAuthError = false;
            //var loginResponseDto = await _authenticationService.Login(_loginRequestDto);

            //if (!loginResponseDto.Success)
            //{
            //    ShowAuthError = true;
            //    Errors = loginResponseDto.ErrorList;
            //}
        }

        public async Task ExecuteLogin()
        {
            var loginResponseDto = await _authenticationService.Login(_loginRequestDto);
            if (!loginResponseDto.Success)
            {
                ShowAuthError = true;
                Errors = loginResponseDto.ErrorList;
            }
            else
            {
                ShowAuthError = false;
                SuccessfulLogin = true;
            }
        }
    }
}
