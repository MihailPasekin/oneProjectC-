using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Codelistdetail
{
    public string Codelistcode { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
