using EComersObjectLib;

namespace MudBlazorAdminPanel.Models
{
    public class CurrentUser
    {
        public bool IsAuthenticated { get; set; }
        public User User { get; set; }
        public Dictionary<string, string> Claims { get; set; }
    }
}
