using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Skuuom
{
    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string Uom { get; set; } = null!;

    public string? Eanupc { get; set; }

    public double? Grossweight { get; set; }

    public double? Netweight { get; set; }

    public double? Length { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public double? Volume { get; set; }

    public string Loweruom { get; set; } = null!;

    public decimal? Unitspermeasure { get; set; }

    public decimal? Unitsperlowestuom { get; set; }

    public bool? Shippable { get; set; }

    public string? Packagetype { get; set; }

    public string? Grabtype { get; set; }

    public string? Casepreparationtype { get; set; }

    public string? Eachhandlingtype { get; set; }

    public string? Laborpackagetype { get; set; }

    public string? Laborgrabtype { get; set; }

    public string? Laborpreparationtype { get; set; }

    public string? Laborhandlingtype { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
