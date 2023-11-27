using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class Log
    {
        private DateTime logCreatedDate;

        public int LogId { get; set; }
        public int LogLevel { get; set; }
        public string? LogDesctiption { get; set; }
        public DateTime LogCreatedDate { 
            get 
            {
                return DateTimeUtils.ConvertDateTimeFromUtc(logCreatedDate) ; 
            } 
            set 
            { 
                logCreatedDate = value; 
            } 
        }

    }
}
