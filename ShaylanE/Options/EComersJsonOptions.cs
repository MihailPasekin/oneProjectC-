
using System.Text.Json;

namespace EComersWebApiEmploe.Options
{
    public class EComersJsonOptions : JsonNamingPolicy
    {
        
        public override string ConvertName(string name)
        {
            return name;
        }
        
    }
}
