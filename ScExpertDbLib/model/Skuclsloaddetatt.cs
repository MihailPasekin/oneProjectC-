using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Skuclsloaddetatt
{
    public string Classname { get; set; } = null!;

    public string Attributename { get; set; } = null!;

    public string Attributetype { get; set; } = null!;

    public bool Attcapin { get; set; }

    public bool Attcapout { get; set; }

    public string Attcapuom { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
