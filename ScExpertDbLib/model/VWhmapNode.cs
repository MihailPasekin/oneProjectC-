using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VWhmapNode
{
    public string Objectid { get; set; } = null!;

    public string Templatename { get; set; } = null!;

    public int Xposition { get; set; }

    public int Yposition { get; set; }

    public int? Zposition { get; set; }

    public int Angle { get; set; }

    public int TemplateWidth { get; set; }

    public int TemplateHeight { get; set; }
}
