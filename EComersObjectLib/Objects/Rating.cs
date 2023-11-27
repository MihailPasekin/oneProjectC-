using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib
{
    public class Rating
    {
        public int RatingId { get; set; }
        public int EmployeId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public int? LastUpdatedUserId { get; set; }

        public Employe Employe { get; set; }
        public List<RatingHistory>  RatingHistories { get; set; }

        public Rating(int userId, DateTime createdDate)
        {
            UserId = userId;
            CreatedDate = createdDate;
        }

    }
}
