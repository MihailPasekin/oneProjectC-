using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Depot
{
    public string Depotname { get; set; } = null!;

    public string? Description { get; set; }

    public string Depottype { get; set; } = null!;

    public string? Contact { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
