using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class LblCont
{
    public string Containerid { get; set; } = null!;

    public string? Hutype { get; set; }

    public string? Oncontainer { get; set; }

    public string? Usagetype { get; set; }

    public string? Serial { get; set; }
}
