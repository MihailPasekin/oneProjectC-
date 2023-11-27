using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Asrshandofflocation
{
    public string Mfcid { get; set; } = null!;

    public string Aisle { get; set; } = null!;

    public string Fromlocation { get; set; } = null!;

    public string? Tolocation { get; set; }
}
