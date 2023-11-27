using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Putawaypolicydetail
{
    public int Policyline { get; set; }

    public string Putawaypolicy { get; set; } = null!;

    public int Priority { get; set; }

    public string? Putregion { get; set; }

    public string? Locstoragetype { get; set; }

    public string? Content { get; set; }

    public bool? Fitbyvolume { get; set; }

    public bool? Fitbyweight { get; set; }

    public bool? Fitbyheight { get; set; }

    public bool? Fitbypallettype { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
