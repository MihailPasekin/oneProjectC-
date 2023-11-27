using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Event
{
    public int Eventid { get; set; }

    public string? Description { get; set; }

    public string? Eventtype { get; set; }

    public string? Eventtranstype { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
