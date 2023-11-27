using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Wave
{
    public string Wave1 { get; set; } = null!;

    public DateTime? Createdate { get; set; }

    public DateTime? Releasedate { get; set; }

    public string? Status { get; set; }

    public string? Wavetype { get; set; }

    public DateTime? Closedate { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
