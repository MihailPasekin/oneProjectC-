using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib
{
    internal static class DateTimeUtils
    {
        internal static DateTime ConvertDateTimeFromUtc(DateTime datTime)
        {
            try
            {
                
                return TimeZoneInfo.ConvertTimeFromUtc(datTime, TimeZoneInfo.Local);
            }
            catch (Exception ex)
            {

                return DateTime.MinValue;
            }
        }
    }
}
