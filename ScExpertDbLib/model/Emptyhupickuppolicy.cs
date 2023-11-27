using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Emptyhupickuppolicy
{
    public string Pickregion { get; set; } = null!;

    public string Hutype { get; set; } = null!;

    public string Emptyhulocation { get; set; } = null!;

    public int Taskpriority { get; set; }
}
