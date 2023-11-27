using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Skuclsatt
{
    public string Classname { get; set; } = null!;

    public string Attributename { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
