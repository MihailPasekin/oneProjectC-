using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Mappointtype
{
    public int Mappointtypeid { get; set; }

    public string Name { get; set; } = null!;

    public int Color { get; set; }

    public string? Adduser { get; set; }

    public DateTime Adddate { get; set; }

    public string? Edituser { get; set; }

    public DateTime Editdate { get; set; }
}
