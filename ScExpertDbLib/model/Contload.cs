using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Contload
{
    public string? Containerid { get; set; }

    public string Loadid { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }

    public DateTime? Lastmovedate { get; set; }
}
