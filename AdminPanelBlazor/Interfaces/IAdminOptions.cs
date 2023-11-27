using EComersObjectLib;

namespace AdminPanelBlazor.Interfaces
{
    public interface IAdminOptions
    {
        public Task<string> CreateUser(User user);
    }
}
