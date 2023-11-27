using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Countbook
{
    public string Countbook1 { get; set; } = null!;

    public string Countbookrunid { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime Createdate { get; set; }

    public DateTime? Closedate { get; set; }

    public string? Counttype { get; set; }

    public string? Note { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
