using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VProductionOrder
{
    public string Receipt { get; set; } = null!;

    public string? Status { get; set; }

    public DateTime? Scheduleddate { get; set; }

    public string? Bol { get; set; }

    public string? Notes { get; set; }

    public string? Carriercompany { get; set; }

    public DateTime? Startreceiptdate { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }

    public int Receiptline { get; set; }

    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string? Orderid { get; set; }

    public int? Orderline { get; set; }

    public string? Skudesc { get; set; }

    public decimal? Qtyexpected { get; set; }

    public decimal? Qtyreceived { get; set; }

    public DateTime? Expirydate { get; set; }

    public string? Lot { get; set; }

    public string? ReceivingStatus { get; set; }

    public decimal? RemainQty { get; set; }
}
