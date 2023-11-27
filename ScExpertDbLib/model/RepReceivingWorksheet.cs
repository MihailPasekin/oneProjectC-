using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepReceivingWorksheet
{
    public string Receipt { get; set; } = null!;

    public string? Status { get; set; }

    public DateTime? Scheduleddate { get; set; }

    public string? Bol { get; set; }

    public string? Notes { get; set; }

    public string? Carriercompany { get; set; }

    public DateTime? Startreceiptdate { get; set; }

    public string? Carriername { get; set; }

    public int Receiptline { get; set; }

    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string? Orderid { get; set; }

    public int? Orderline { get; set; }

    public decimal? Qtyexpected { get; set; }

    public decimal? Qtyreceived { get; set; }

    public string? Documenttype { get; set; }

    public string? Skudesc { get; set; }

    public string? Consigneename { get; set; }

    public string? Manufacturersku { get; set; }

    public string? Companyname { get; set; }

    public string? Othercompany { get; set; }
}
