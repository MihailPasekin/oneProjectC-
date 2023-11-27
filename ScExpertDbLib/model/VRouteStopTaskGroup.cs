using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VRouteStopTaskGroup
{
    public string? Consignee { get; set; }

    public string? Documentid { get; set; }

    public string Status { get; set; } = null!;

    public string Runid { get; set; } = null!;
}
