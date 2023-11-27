using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Shipmentload
{
    public string Shipment { get; set; } = null!;

    public string Loadid { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
