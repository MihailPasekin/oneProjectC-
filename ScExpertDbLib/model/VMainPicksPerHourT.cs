using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VMainPicksPerHourT
{
    public string Dayhour { get; set; } = null!;

    public int? Numpicks { get; set; }
}
