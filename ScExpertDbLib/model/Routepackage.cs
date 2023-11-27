using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Routepackage
{
    public string Packageid { get; set; } = null!;

    public string Packagetype { get; set; } = null!;

    public string Documenttype { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Documentid { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime Statusdate { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
