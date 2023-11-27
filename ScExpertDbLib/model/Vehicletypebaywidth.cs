using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Vehicletypebaywidth
{
    public string Vehicletype { get; set; } = null!;

    public string Side { get; set; } = null!;

    public int? Bay { get; set; }

    public double? Maxbaywidth { get; set; }
}
