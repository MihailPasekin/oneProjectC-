using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Shifttaskdelay
{
    public string Shiftid { get; set; } = null!;

    public string Task { get; set; } = null!;

    public decimal? Time { get; set; }
}
