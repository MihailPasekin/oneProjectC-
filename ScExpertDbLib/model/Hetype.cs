using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Hetype
{
    public string Handlingequipment { get; set; } = null!;

    public string Mhctype { get; set; } = null!;

    public bool? Access { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
