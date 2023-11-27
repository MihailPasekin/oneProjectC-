using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Packinglistdetail
{
    public string Packinglistid { get; set; } = null!;

    public string Loadid { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
