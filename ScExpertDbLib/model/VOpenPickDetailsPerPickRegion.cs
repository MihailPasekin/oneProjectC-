using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VOpenPickDetailsPerPickRegion
{
    public string Picklist { get; set; } = null!;

    public int Picklistline { get; set; }

    public string? Pickregion { get; set; }

    public string? Fromlocation { get; set; }

    public string? Status { get; set; }
}
