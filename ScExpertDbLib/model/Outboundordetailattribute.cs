using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Outboundordetailattribute
{
    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public int Orderline { get; set; }

    public string? Referenceordline { get; set; }

    public string? Sku { get; set; }

    public string Inventorystatus { get; set; } = null!;

    public decimal? Qtyoriginal { get; set; }

    public decimal? Qtymodified { get; set; }

    public decimal? Qtyallocated { get; set; }

    public decimal? Qtysoftallocated { get; set; }

    public decimal? Qtypicked { get; set; }

    public decimal? Qtystaged { get; set; }

    public decimal? Qtyloaded { get; set; }

    public decimal? Qtyshipped { get; set; }

    public long? Exploadedflag { get; set; }

    public string? Lineoum { get; set; }

    public decimal? Uomqty { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;

    public string? Inputsku { get; set; }

    public string? Inputqtyuom { get; set; }

    public decimal? Inputqty { get; set; }

    public string? Pkeytype { get; set; }

    public string? Pkey1 { get; set; }

    public string? Pkey2 { get; set; }

    public string? Pkey3 { get; set; }

    public DateTime? Expirydate { get; set; }

    public decimal? Weight { get; set; }

    public string? Serial { get; set; }

    public bool? Kosher { get; set; }

    public int? Harvest { get; set; }

    public string? Color { get; set; }

    public string? Size { get; set; }

    public string? Batch { get; set; }

    public DateTime? Mfgdate { get; set; }

    public string? Notes { get; set; }

    public decimal? Qtypacked { get; set; }

    public decimal? Qtyverified { get; set; }
}
