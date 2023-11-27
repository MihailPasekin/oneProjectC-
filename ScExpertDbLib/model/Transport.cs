using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Transport
{
    public string Transportid { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Transportorderid { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Bol { get; set; }

    public string Fromcontactid { get; set; } = null!;

    public string Frompointid { get; set; } = null!;

    public string Tocontactid { get; set; } = null!;

    public string Topointid { get; set; } = null!;

    public decimal? Loadingtime { get; set; }

    public decimal? Unloadingtime { get; set; }

    public decimal? Drivetime { get; set; }

    public DateTime? Plannedstarttime { get; set; }

    public DateTime? Actualstarttime { get; set; }

    public DateTime? Plannedendtime { get; set; }

    public DateTime? Actualendtime { get; set; }

    public string? Vehicleid { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
