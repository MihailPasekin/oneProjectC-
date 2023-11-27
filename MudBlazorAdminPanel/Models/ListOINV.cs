using EComersObjectLib.SapObjects;

namespace MudBlazorAdminPanel.Models
{
    public class ListOINV
    {
        public double TotalSumm { get { return Math.Round(ListOinvs.Where(p => p.Confirm == true).Sum(p => p.PaySum), 2); } }
        public List<OINV> ListOinvs { get; set; }
    }
}
