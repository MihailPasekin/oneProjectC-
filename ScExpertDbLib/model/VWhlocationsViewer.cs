using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VWhlocationsViewer
{
    public string Objectid { get; set; } = null!;

    public string Templatename { get; set; } = null!;

    public int? Xposition { get; set; }

    public int? Yposition { get; set; }

    public int? Zposition { get; set; }

    public string? Aisle { get; set; }

    public string? Bay { get; set; }

    public int? Loclevel { get; set; }

    public string? Checkdigits { get; set; }

    public string? Putregion { get; set; }

    public string? Pickregion { get; set; }

    public string? Warehousearea { get; set; }

    public string Status { get; set; } = null!;

    public int Angle { get; set; }

    public int TemplateWidth { get; set; }

    public int TemplateHeight { get; set; }
}
