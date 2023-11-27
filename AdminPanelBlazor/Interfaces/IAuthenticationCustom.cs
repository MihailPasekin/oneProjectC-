using EComersObjectLib;

namespace AdminPanelBlazor.Interfaces
{
    public interface IAuthenticationCustom
    {
        // Task<User> GetAuthentication(string login, string password);
        public Task<string> TryAuthenticateUserAsync(string login, string password);
    }
}
