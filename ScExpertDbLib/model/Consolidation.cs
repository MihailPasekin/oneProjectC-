using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Consolidation
{
    public string Consolidateid { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Tocontainer { get; set; } = null!;

    public string Handlingunittype { get; set; } = null!;

    public string Usagetype { get; set; } = null!;

    public string? Serial { get; set; }

    public string Destinationlocation { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
