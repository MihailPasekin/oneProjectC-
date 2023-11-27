using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Adjustment
{
    public string Adjustment1 { get; set; } = null!;

    public string? Consignee { get; set; }

    public string? Consigneeref { get; set; }

    public string? Status { get; set; }

    public string? Invadjrc { get; set; }

    public string? Notes { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
