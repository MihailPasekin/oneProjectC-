using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VYardLocation
{
    public string Objectid { get; set; } = null!;

    public string? Yardlocationtype { get; set; }

    public string TemplateName { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int? Xposition { get; set; }

    public int? Yposition { get; set; }

    public int TemplateWidth { get; set; }

    public int TemplateHeight { get; set; }

    public string Locationid { get; set; } = null!;

    public string? Yardarea { get; set; }

    public string? Checkdigits { get; set; }

    public string Occupied { get; set; } = null!;

    public int NumEquipments { get; set; }

    public int Angle { get; set; }
}
