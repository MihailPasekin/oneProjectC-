using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Fixroutesstop
{
    public string Routename { get; set; } = null!;

    public string Stop { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string? Companytype { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
