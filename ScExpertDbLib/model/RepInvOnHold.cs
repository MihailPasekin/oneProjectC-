using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepInvOnHold
{
    public string Loadid { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Statusdesc { get; set; }

    public string? Activitystatus { get; set; }

    public string? Activitystatusdesc { get; set; }

    public string Location { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string? Consigneename { get; set; }

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }

    public string? Receipt { get; set; }

    public int? Receiptline { get; set; }

    public decimal Units { get; set; }
}
