using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepLoadByStatus
{
    public DateTime? Activitydate { get; set; }

    public string? Consignee { get; set; }

    public string? Sku { get; set; }

    public string? Fromload { get; set; }

    public string? Toload { get; set; }

    public string? Fromstatus { get; set; }

    public string? Tostatus { get; set; }

    public string? Adduser { get; set; }

    public string? Skudesc { get; set; }
}
