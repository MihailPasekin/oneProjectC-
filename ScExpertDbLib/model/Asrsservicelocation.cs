using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Asrsservicelocation
{
    public string Mfcid { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string? Locationtype { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
