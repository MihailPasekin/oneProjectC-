using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Wavetype
{
    public string Wavetype1 { get; set; } = null!;

    public double? Fullpick { get; set; }

    public double? Partpick { get; set; }

    public double? Negpick { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
