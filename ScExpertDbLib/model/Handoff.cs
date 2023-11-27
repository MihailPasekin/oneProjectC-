using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Handoff
{
    public string Fromhandoffregion { get; set; } = null!;

    public string Tohandoffregion { get; set; } = null!;

    public string Handofflocation { get; set; } = null!;

    public int Priority { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
