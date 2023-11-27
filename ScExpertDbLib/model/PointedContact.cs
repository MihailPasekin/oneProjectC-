using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class PointedContact
{
    public string Consignee { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string Contactid { get; set; } = null!;

    public string? Street1 { get; set; }

    public string? Street2 { get; set; }

    public string? City { get; set; }

    public string? Contact1name { get; set; }

    public string? Pointid { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }
}
