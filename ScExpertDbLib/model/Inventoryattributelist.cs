using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Inventoryattributelist
{
    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Type { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
