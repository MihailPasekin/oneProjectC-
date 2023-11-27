using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VHandOff
{
    public string? Fromhandoffregion { get; set; }

    public string? Tohandoffregion { get; set; }

    public string Handofflocation { get; set; } = null!;

    public int Priority { get; set; }

    public bool Status { get; set; }

    public int Numloads { get; set; }

    public int Loadscapacity { get; set; }

    public string? Locmhtype { get; set; }
}
