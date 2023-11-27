
using System.Text.Json;

namespace ECommersAdminPanel2.Options
{
    public class EComersJsonOptions : JsonNamingPolicy
    {
        
        public override string ConvertName(string name)
        {
            return name;
        }
        
    }
}
