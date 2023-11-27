using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VSnapShot
{
    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public decimal? Qty { get; set; }

    public string? Status { get; set; }
}
