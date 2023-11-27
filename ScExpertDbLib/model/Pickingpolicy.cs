using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Pickingpolicy
{
    public string Policyname { get; set; } = null!;

    public string Pickregion { get; set; } = null!;

    public string Pickmethod { get; set; } = null!;

    public string? Loaduom { get; set; }

    public string? Container { get; set; }

    public bool? Printpicklist { get; set; }

    public bool? Buildpicklist { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
