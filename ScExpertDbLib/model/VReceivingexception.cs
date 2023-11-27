using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VReceivingexception
{
    public string Receipt { get; set; } = null!;

    public string Receiptline { get; set; } = null!;

    public decimal? Qty { get; set; }

    public string? Reasoncode { get; set; }

    public DateTime? Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime? Editdate { get; set; }

    public string? Edituser { get; set; }

    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }
}
