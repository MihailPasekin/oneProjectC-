using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Taskpolicyscoring
{
    public string Policyid { get; set; } = null!;

    public decimal? Priority { get; set; }

    public decimal? Creationdate { get; set; }

    public decimal? Distance { get; set; }
}
