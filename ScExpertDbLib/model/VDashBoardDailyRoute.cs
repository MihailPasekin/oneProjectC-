using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VDashBoardDailyRoute
{
    public string Routeid { get; set; } = null!;

    public string? Vehicleid { get; set; }

    public string? Driver { get; set; }

    public string? Routename { get; set; }
}
