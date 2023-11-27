using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Vehicle
{
    public string Vehicleid { get; set; } = null!;

    public string Vehicletypename { get; set; } = null!;

    public string? Driverid { get; set; }

    public string? Name { get; set; }

    public string? Comment { get; set; }

    public string? Carrier { get; set; }

    public string? Vehicletype { get; set; }

    public string? Yardlocation { get; set; }

    public bool? Status { get; set; }

    public string? Activitystatus { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }

    public DateTime? Licensethrudate { get; set; }

    public DateTime? Manufacturedate { get; set; }
}
