using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VReplanRunId
{
    public string? Routeset { get; set; }

    public string Runid { get; set; } = null!;
}
