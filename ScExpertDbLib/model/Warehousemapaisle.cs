using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Warehousemapaisle
{
    public string Aisle { get; set; } = null!;

    public string Nodeid { get; set; } = null!;

    public bool? Accessin { get; set; }

    public bool? Accessout { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
