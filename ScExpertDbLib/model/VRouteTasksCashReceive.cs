using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VRouteTasksCashReceive
{
    public string Company { get; set; } = null!;

    public string? Companyname { get; set; }

    public string? Consignee { get; set; }

    public string? Driver { get; set; }

    public string Fullname { get; set; } = null!;

    public int Stopnumber { get; set; }

    public int Stoptaskid { get; set; }

    public string Routeid { get; set; } = null!;

    public string? Documentid { get; set; }

    public string? Documenttype { get; set; }

    public string Status { get; set; } = null!;

    public string? Comments { get; set; }

    public string Confirmationlevel { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string Edituser { get; set; } = null!;

    public int? Mst { get; set; }

    public decimal? Received { get; set; }
}
