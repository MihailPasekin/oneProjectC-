using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Parallelpick
{
    public string Parallelpickid { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Tocontainer { get; set; }

    public string? Handlingunittype { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
