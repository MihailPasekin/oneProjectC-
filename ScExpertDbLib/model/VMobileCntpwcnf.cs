using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VMobileCntpwcnf
{
    public string Task { get; set; } = null!;

    public string? ContainerId { get; set; }

    public string? Location { get; set; }

    public string Spacer { get; set; } = null!;

    public string Confirm { get; set; } = null!;
}
