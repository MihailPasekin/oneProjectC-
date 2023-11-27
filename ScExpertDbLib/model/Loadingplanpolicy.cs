using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Loadingplanpolicy
{
    public string Loadingplanpolicy1 { get; set; } = null!;

    public string Pickmethod { get; set; } = null!;

    public string? Handlingunit { get; set; }

    public string? Stackoverfullpallets { get; set; }

    public bool? Maxcustomers { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
