using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VLocationGrid
{
    public string Location { get; set; } = null!;

    public bool Status { get; set; }

    public string? Putregion { get; set; }

    public string? Pickregion { get; set; }

    public string? Warehousearea { get; set; }

    public string? Locsortorder { get; set; }

    public string? Loctpickype { get; set; }

    public string? Locstoragetype { get; set; }

    public string? Locusagetype { get; set; }

    public bool Inventory { get; set; }

    public DateTime? Lastcountdate { get; set; }

    public string Accesstype { get; set; } = null!;

    public int? Accessibleloads { get; set; }

    public double? Length { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public double? Weight { get; set; }

    public double? Cubic { get; set; }

    public int Loadscapacity { get; set; }

    public string? Checkdigits { get; set; }

    public bool Looseid { get; set; }

    public string? Aisle { get; set; }

    public string? Bay { get; set; }

    public int? Loclevel { get; set; }

    public double? Heightfromfloor { get; set; }

    public DateTime? Lastmovein { get; set; }

    public DateTime? Lastmoveout { get; set; }

    public int? Picksfromlastcount { get; set; }

    public int? Xcoordinate { get; set; }

    public int? Ycoordinate { get; set; }

    public int? Zcoordinate { get; set; }

    public string? Inhandoff { get; set; }

    public string? Outhandoff { get; set; }

    public string? Laborhufacing { get; set; }

    public string? Laborinserttype { get; set; }

    public string? Laborretrievetype { get; set; }

    public string? Laborpicktype { get; set; }

    public string? Laborreachtype { get; set; }

    public string? Congestionregion { get; set; }

    public bool Problemflag { get; set; }

    public string? Hustoragetemplate { get; set; }

    public string? Zpicking { get; set; }

    public string? Locaccessibility { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;

    public string? Locmhtype { get; set; }

    public string? Locmhtypedescription { get; set; }
}
