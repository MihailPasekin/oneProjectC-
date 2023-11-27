using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib
{
    public class RatingHistory
    {
        public int RatingHistoryId { get; set; }
        public int RatingId { get; set; }
        public int RatingStatusId { get; set; }
        public int? AchievementId { get; set; }
        public string? AchievementDescription { get; set; }
        public int NumHistory { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int UserId { get; set; }

        public Rating Rating { get; set; }
        public RatingStatus Status { get; set; }
    }
}
