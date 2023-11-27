using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VDeliveryProgressRouteCompletedStop
{
    public string Routeid { get; set; } = null!;

    public double? Stopscount { get; set; }
}
