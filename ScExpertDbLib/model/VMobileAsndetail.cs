using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VMobileAsndetail
{
    public int? NumLoads { get; set; }

    public string Container { get; set; } = null!;

    public string Receipt { get; set; } = null!;

    public string? Location { get; set; }

    public string? Usagetype { get; set; }
}
