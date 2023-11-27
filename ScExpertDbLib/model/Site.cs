using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Site
{
    public string Siteid { get; set; } = null!;

    public string? Sitename { get; set; }

    public string? Contactid { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
