using EComersObjectLib;
using MudBlazorAdminPanel.Models;

namespace MudBlazorAdminPanel.Interfaces
{
    public interface IAuthenticationCustom
    {
        Task Login(string login, string password);
        Task Logout();
        Task<CurrentUser> CurrentUserInfo();
    }
}
