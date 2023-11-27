using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VYardVehiclesPosition
{
    public string Objectid { get; set; } = null!;

    public string TemplateName { get; set; } = null!;

    public int TemplateWidth { get; set; }

    public int TemplateHeight { get; set; }

    public string? Vehicle { get; set; }

    public string? Trailer { get; set; }

    public string? Locationid { get; set; }

    public int? Xposition { get; set; }

    public int? Yposition { get; set; }

    public int Angle { get; set; }

    public string? Yardarea { get; set; }
}
