using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Billingplugin
{
    public int Pluginid { get; set; }

    public string Type { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Dll { get; set; } = null!;

    public string Class { get; set; } = null!;
}
