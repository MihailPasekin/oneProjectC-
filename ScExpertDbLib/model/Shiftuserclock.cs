using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Shiftuserclock
{
    public string Shiftid { get; set; } = null!;

    public string Userid { get; set; } = null!;

    public int Clockinout { get; set; }

    public DateTime? Clocktime { get; set; }

    public DateTime Adddate { get; set; }
}
