using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VWaveassignment
{
    public string Templatename { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string? Ordertype { get; set; }

    public string? Company { get; set; }

    public string? Companytype { get; set; }

    public string Fromroute { get; set; } = null!;

    public string Toroute { get; set; } = null!;

    public string? Fromdoor { get; set; }

    public string? Todoor { get; set; }

    public string? Carrier { get; set; }

    public string? Transmethod { get; set; }

    public string? Orderstatus { get; set; }

    public bool? Slassigned { get; set; }

    public int Maxnumoforders { get; set; }

    public string Wavetype { get; set; } = null!;

    public string? Wavetypedesc { get; set; }

    public string Planmethod { get; set; } = null!;

    public string? Planmethoddesc { get; set; }

    public bool Breakbyshipment { get; set; }

    public decimal? Fromvolume { get; set; }

    public decimal? Tovolume { get; set; }

    public int? Fromrequesteddeliverydate { get; set; }

    public int? Torequesteddeliverydate { get; set; }
}
