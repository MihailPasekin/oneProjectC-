using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.SapObjects
{
    public class OITM
    {
        public int? ItemId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
        public string WhsName { get; set; }
        public double ItemCount { get; set; }
        public bool ItemForOrder { get; set; }
        public double ItemCountForOrder { get; set; }
        public string PicturName { get; set; }
        public int? OrderId { get; set; }
        public int ItmsGrpCod { get; set; }

        public Order? OrderForServer { get; set; }
    }
}
