using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Skuattributelist
{
    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Type { get; set; } = null!;

    public string? Validator { get; set; }
}
