using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Mapterritoryset
{
    public string Territorysetid { get; set; } = null!;

    public string? Territorysetname { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
