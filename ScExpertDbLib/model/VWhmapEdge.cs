using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VWhmapEdge
{
    public string Sourceobjectid { get; set; } = null!;

    public string Targetobjectid { get; set; } = null!;

    public double Distance { get; set; }

    public string Edgetype { get; set; } = null!;
}
