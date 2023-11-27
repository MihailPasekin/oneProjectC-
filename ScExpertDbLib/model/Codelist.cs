using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Codelist
{
    public string Code { get; set; } = null!;

    public string? Description { get; set; }

    public bool? Allowedit { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
