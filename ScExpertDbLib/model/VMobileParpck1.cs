using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VMobileParpck1
{
    public string Task { get; set; } = null!;

    public string Assigned { get; set; } = null!;

    public string? Picklist { get; set; }

    public string Spacer { get; set; } = null!;

    public int NumPicklists { get; set; }

    public int NumPicks { get; set; }

    public string InnerHandlingUnitType { get; set; } = null!;

    public string? ContainerType { get; set; }

    public string ContainerId { get; set; } = null!;
}
