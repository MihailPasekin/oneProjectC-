using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Countbookaudit
{
    public string Countbook { get; set; } = null!;

    public string Countid { get; set; } = null!;

    public string Countbookrunid { get; set; } = null!;

    public string Loadid { get; set; } = null!;

    public string Location { get; set; } = null!;

    public decimal? Expectedqty { get; set; }

    public decimal? Countqty { get; set; }

    public string? Userid { get; set; }

    public DateTime? Countdate { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
