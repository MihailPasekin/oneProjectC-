using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepReceivingBySku
{
    public string Consignee { get; set; } = null!;

    public string? Sku { get; set; }

    public string? Skudesc { get; set; }

    public string Orderid { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public DateTime? Createdate { get; set; }

    public decimal? Qtyordered { get; set; }

    public decimal? Qtyreceived { get; set; }

    public DateTime? Expecteddate { get; set; }

    public DateTime? Lastreceiptdate { get; set; }

    public string? Adduser { get; set; }
}
