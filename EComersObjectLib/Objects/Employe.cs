using EComersObjectLib.Objects;

namespace EComersObjectLib
{
    public class Employe
    {
        private DateTime createdDate;

        public int EmployeId { get; set; }
        public DateTime CreatedDate { get { return DateTimeUtils.ConvertDateTimeFromUtc(createdDate); } set { createdDate = value; } }
        public DateTime? UpdatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public int? UpdatedUserId { get; set; }
        public int EmployeSapId { get; set; }

        public List<Rating> Ratings { get; set; }
        public List<EmployeHistory> EmployeHistory{ get; set; }
        public User? CreatedUser { get; set; }
        public User? UpdatedUser { get; set; }
        public List<MerchVisit>? MerchVisits { get; set; }
        public List<PlanReport>? PlanReport { get; set; }


        public override string ToString()
        {
            EmployeHistory history = GetActualEmployeHistory();
            return string.Concat(EmployeId," ", history.Name," ", history.SecondName );
        }

        public EmployeHistory? GetActualEmployeHistory()
        {
            DateTime requestDate = DateTime.Now;
            if (EmployeHistory != null && EmployeHistory.Count > 0)
            {
                return EmployeHistory.Where(p => p.StartDate < requestDate && requestDate < p.EndDate).First();
            }
            return null;
        }
    }
}