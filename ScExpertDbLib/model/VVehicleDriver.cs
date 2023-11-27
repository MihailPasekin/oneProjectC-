using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VVehicleDriver
{
    public string Vehicleid { get; set; } = null!;

    public string Vehicletypename { get; set; } = null!;

    public string? Driverid { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Fullname { get; set; }
}
