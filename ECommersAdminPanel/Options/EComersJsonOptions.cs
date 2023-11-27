
using System.Text.Json;

namespace ECommersAdminPanel.Options
{
    public class EComersJsonOptions : JsonNamingPolicy
    {
        
        public override string ConvertName(string name)
        {
            return name;
        }
        
    }
}
