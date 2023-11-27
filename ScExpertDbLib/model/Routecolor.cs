using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Routecolor
{
    public int ColorId { get; set; }

    public string ColorInt { get; set; } = null!;

    public string ColorRgb { get; set; } = null!;
}
