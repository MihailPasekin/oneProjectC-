using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Vehicletypebayheight
{
    public string Vehicletype { get; set; } = null!;

    public int? Bay { get; set; }

    public double? Bayheight { get; set; }
}
