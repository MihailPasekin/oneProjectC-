using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VDashBoardRoute
{
    public string Routeid { get; set; } = null!;

    public int Stopnumber { get; set; }

    public string? Tooltip { get; set; }

    public string? Infowindow { get; set; }

    public string? Routename { get; set; }

    public string Company { get; set; } = null!;

    public string? Companyname { get; set; }

    public string? Address { get; set; }

    public string? Documentid { get; set; }

    public int? Numpacks { get; set; }

    public string? Actualarrivaldate { get; set; }

    public string? Reasoncode { get; set; }

    public double? Lon { get; set; }

    public double? Lat { get; set; }

    public string Pointid { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string Stopstatus { get; set; } = null!;

    public string Shadowimage { get; set; } = null!;

    public int Caption { get; set; }
}
