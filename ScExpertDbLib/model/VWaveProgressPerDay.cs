using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VWaveProgressPerDay
{
    public string Wave { get; set; } = null!;

    public string Picklist { get; set; } = null!;

    public int Picklistline { get; set; }

    public string? Status { get; set; }

    public DateTime? Releasedate { get; set; }
}
