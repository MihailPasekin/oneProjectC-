using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VShowCompContact
{
    public string? Companyname { get; set; }

    public string Consignee { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string? Street1 { get; set; }

    public string? Street2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? Zip { get; set; }

    public string? Pointid { get; set; }

    public string Contactid { get; set; } = null!;

    public double? Lat { get; set; }

    public double? Lon { get; set; }

    public string? Infowindow { get; set; }

    public string? Tooltip { get; set; }

    public string Address { get; set; } = null!;

    public bool? Pinned { get; set; }
}
