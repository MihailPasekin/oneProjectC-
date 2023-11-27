using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Routebreaktype
{
    public string Breaktype { get; set; } = null!;

    public string Breaktypename { get; set; } = null!;

    public int Duration { get; set; }
}
