using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Asrstask
{
    public string Connectionid { get; set; } = null!;

    public string Asrstaskid { get; set; } = null!;

    public string Mfcid { get; set; } = null!;

    public string? Priority { get; set; }

    public DateTime? Createdate { get; set; }

    public DateTime? Executiondate { get; set; }

    public string? Whtask { get; set; }

    public string? Huid { get; set; }

    public string? Fromloc { get; set; }

    public string? Fromsublocation { get; set; }

    public string? Executionlocation { get; set; }

    public string? Toloc { get; set; }

    public string? Tosublocation { get; set; }

    public string? Status { get; set; }

    public string? Rejectreason { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
