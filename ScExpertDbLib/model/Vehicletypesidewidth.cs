using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Vehicletypesidewidth
{
    public string Vehicletype { get; set; } = null!;

    public string Side { get; set; } = null!;

    public double? Sidewidth { get; set; }
}
