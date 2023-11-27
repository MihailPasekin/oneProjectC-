using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VRouteStopPkgSum
{
    public string Routeid { get; set; } = null!;

    public int? NumberOfStops { get; set; }

    public int? NumberOfPackages { get; set; }
}
