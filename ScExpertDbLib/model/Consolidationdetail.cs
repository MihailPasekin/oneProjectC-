using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Consolidationdetail
{
    public string Consolidateid { get; set; } = null!;

    public int Consolidateline { get; set; }

    public string? Fromload { get; set; }

    public string Fromlocation { get; set; } = null!;

    public string? Fromcontainer { get; set; }

    public string Status { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
