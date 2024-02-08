namespace Last.Services.RefreshToken
{
    public interface IRefreshTokenService
    {
        public Task<string> TryToRefresh();
    }
}
