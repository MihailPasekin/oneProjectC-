using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Asrsdeliverylocation
{
    public string Fromaisle { get; set; } = null!;

    public string Toaisle { get; set; } = null!;

    public string Tasktype { get; set; } = null!;

    public string? Deliverylocation { get; set; }
}
