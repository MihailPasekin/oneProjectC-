using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Eventsregistration
{
    public int Eventid { get; set; }

    public string Queuename { get; set; } = null!;

    public int? Priority { get; set; }

    public bool? Synchronize { get; set; }
}
