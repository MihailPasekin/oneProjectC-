using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VMobilePck
{
    public string Task { get; set; } = null!;

    public string Assigned { get; set; } = null!;

    public string? Picklist { get; set; }

    public string Spacer { get; set; } = null!;

    public string? PickType { get; set; }

    public string? PickMethod { get; set; }

    public string? ContainerType { get; set; }

    public string? ContainerTypeDesc { get; set; }

    public string ContainerId { get; set; } = null!;
}
