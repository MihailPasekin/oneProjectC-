using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VUsersClockIn
{
    public string Userid { get; set; } = null!;

    public string Shiftid { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Hetype { get; set; } = null!;

    public string Mheid { get; set; } = null!;

    public string Inout { get; set; } = null!;

    public string Shiftuserperformance { get; set; } = null!;
}
