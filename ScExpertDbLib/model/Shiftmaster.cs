using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Shiftmaster
{
    public string Shiftcode { get; set; } = null!;

    public string Warehousearea { get; set; } = null!;

    public string? Shiftdescription { get; set; }
}
