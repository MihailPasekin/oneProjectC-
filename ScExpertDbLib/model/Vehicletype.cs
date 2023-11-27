using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Vehicletype
{
    public string Vehicletypename { get; set; } = null!;

    public string? Description { get; set; }

    public double? Costperdistanceunit { get; set; }

    public double? Costperhour { get; set; }

    public double? Costperday { get; set; }

    public decimal? Totalvolume { get; set; }

    public decimal? Totalweight { get; set; }

    public int? Maxroutesperday { get; set; }

    public double? Minpercentusage { get; set; }

    public string? Unloadingtype { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edittuser { get; set; } = null!;

    public string? Equipementtype { get; set; }

    public string? Manufacture { get; set; }

    public string? Model { get; set; }

    public decimal? Vehicleweight { get; set; }

    public decimal? Totalvalue { get; set; }

    public decimal? Totalunits { get; set; }

    public decimal? Drivingtimefactor { get; set; }
}
