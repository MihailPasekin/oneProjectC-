using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class AvailableInboundLine
{
    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string? Companytype { get; set; }

    public int Orderline { get; set; }

    public string? Sku { get; set; }

    public decimal? Qtyadjusted { get; set; }

    public decimal? Qtyreceived { get; set; }

    public string? Referenceord { get; set; }

    public string? Referenceordline { get; set; }

    public string? Inventorystatus { get; set; }

    public string Documenttype { get; set; } = null!;

    public string? Pkeytype { get; set; }

    public string? Pkey1 { get; set; }

    public string? Pkey2 { get; set; }

    public string? Pkey3 { get; set; }

    public DateTime? Mfgdate { get; set; }

    public string? Serial { get; set; }

    public string? Batch { get; set; }

    public string? Size { get; set; }

    public decimal? Weight { get; set; }

    public bool? Kosher { get; set; }

    public int? Harvest { get; set; }

    public string? Color { get; set; }

    public DateTime? Expirydate { get; set; }

    public string? Inputsku { get; set; }

    public string? Inputuom { get; set; }

    public decimal? Inputqty { get; set; }
}
