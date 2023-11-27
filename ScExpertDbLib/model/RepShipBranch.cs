using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepShipBranch
{
    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public int Orderline { get; set; }

    public string? Sku { get; set; }

    public string? Skudesc { get; set; }

    public decimal? Qtyshipped { get; set; }

    public string? Companyname { get; set; }

    public DateTime? Adddate { get; set; }
}
