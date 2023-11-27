using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Laborusercounter
{
    public string Userid { get; set; } = null!;

    public string Laborcounterid { get; set; } = null!;

    public string? Laborcountervalue { get; set; }

    public DateTime? Laborcounterlastresetdate { get; set; }
}
