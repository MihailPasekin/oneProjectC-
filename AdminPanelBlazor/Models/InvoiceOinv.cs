using EComersObjectLib.SapObjects;

namespace AdminPanelBlazor.Models
{
    public class InvoiceOinv:OINV
    {
        public string BtText { get { if (PaySum == 0) return ">>"; else return "<<"; }}
    }
}
