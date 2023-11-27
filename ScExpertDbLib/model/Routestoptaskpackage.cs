using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Routestoptaskpackage
{
    public string Routeid { get; set; } = null!;

    public int Stopnumber { get; set; }

    public int Stoptaskid { get; set; }

    public string Packageid { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
