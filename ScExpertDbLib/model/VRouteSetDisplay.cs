using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VRouteSetDisplay
{
    public string SetId { get; set; } = null!;

    public DateTime? Createdate { get; set; }

    public string? RouteSetDisplay { get; set; }
}
