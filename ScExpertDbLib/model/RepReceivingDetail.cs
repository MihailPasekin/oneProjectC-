using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepReceivingDetail
{
    public string Receipt { get; set; } = null!;

    public DateTime? Startreceiptdate { get; set; }

    public string? Carriercompany { get; set; }

    public string? Bol { get; set; }

    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }

    public decimal? Qtyexpected { get; set; }

    public decimal Qtyreceived { get; set; }

    public int Receiptline { get; set; }
}
