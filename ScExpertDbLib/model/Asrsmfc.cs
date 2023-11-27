using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Asrsmfc
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public string? Subsystemid { get; set; }

    public string? Messagequeue { get; set; }

    public bool? Status { get; set; }

    public string? Instructioncounter { get; set; }

    public string? Rejectlocation { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
