using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VReceiptDetail
{
    public string Receipt { get; set; } = null!;

    public int Receiptline { get; set; }

    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string? Orderid { get; set; }

    public int? Orderline { get; set; }

    public decimal? Qtyexpected { get; set; }

    public decimal? Qtyreceived { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }

    public string? Skudesc { get; set; }

    public DateTime? Expirydate { get; set; }

    public decimal? Weight { get; set; }

    public string? Serial { get; set; }

    public bool? Kosher { get; set; }

    public int? Harvest { get; set; }

    public string? Color { get; set; }

    public string? Size { get; set; }

    public string? Batch { get; set; }

    public DateTime? Mfgdate { get; set; }

    public decimal? Inputqty { get; set; }

    public string? Inputsku { get; set; }

    public string? Inputuom { get; set; }

    public string? Reford { get; set; }

    public string? Refordline { get; set; }

    public string? Inventorystatus { get; set; }

    public string? Company { get; set; }

    public string? Companytype { get; set; }

    public string? Documenttype { get; set; }
}
