using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VRecieptClosedNotification
{
    public string Receipt { get; set; } = null!;

    public DateTime? Startreceiptdate { get; set; }

    public DateTime? Closereceiptdate { get; set; }

    public int Receiptline { get; set; }

    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }

    public string? Orderid { get; set; }

    public int? Orderline { get; set; }

    public decimal? Qtyexpected { get; set; }

    public decimal? Qtyreceived { get; set; }

    public decimal? Qtydiff { get; set; }

    public string Company { get; set; } = null!;

    public string Companyname { get; set; } = null!;
}
