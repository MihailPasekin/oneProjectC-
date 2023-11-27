using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Label
{
    public string Labelname { get; set; } = null!;

    public string? Labeldesc { get; set; }

    public string? Formatfile { get; set; }

    public string? Defaultprinter { get; set; }

    public string? Filetype { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
