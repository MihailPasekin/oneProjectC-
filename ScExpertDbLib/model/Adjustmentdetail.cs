using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Adjustmentdetail
{
    public string Adjustment { get; set; } = null!;

    public int Adjustmentline { get; set; }

    public string? Loadid { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
