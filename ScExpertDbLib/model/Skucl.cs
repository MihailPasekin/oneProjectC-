using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Skucl
{
    public string Classname { get; set; } = null!;

    public string Classdescription { get; set; } = null!;

    public string? Mergevalidationexpression { get; set; }

    public string? Skuattvalidationexpression { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
