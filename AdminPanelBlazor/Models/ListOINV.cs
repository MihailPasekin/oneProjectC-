using EComersObjectLib.SapObjects;

namespace AdminPanelBlazor.Models
{
    public class ListOINV
    {
        public double TotalSumm { get { return Math.Round(ListOinvs.Where(p => p.Confirm == true).Sum(p => p.PaySum), 2); } }
        public List<InvoiceOinv> ListOinvs { get; set; }
    }
}
