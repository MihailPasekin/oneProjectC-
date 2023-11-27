using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VAdjustment
{
    public string Adjustment { get; set; } = null!;

    public string? Consignee { get; set; }

    public string? Consigneeref { get; set; }

    public string? Status { get; set; }

    public string? Invadjrc { get; set; }

    public string? Notes { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;

    public string? Consigneename { get; set; }

    public string? Statusdesc { get; set; }
}
