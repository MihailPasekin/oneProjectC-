using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Putawaypolicy
{
    public string Putawaypolicy1 { get; set; } = null!;

    public string? Policyname { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
