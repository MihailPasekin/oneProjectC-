using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepReceivingSummary
{
    public string Sku { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string? Skudesc { get; set; }

    public decimal? Receivedqty { get; set; }
}
