using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Routingconstraint
{
    public string Contactid { get; set; } = null!;

    public string Routingresourceattribute { get; set; } = null!;

    public string Resourceoperator { get; set; } = null!;

    public string Routingresourceattributevalue { get; set; } = null!;

    public bool Allowed { get; set; }

    public string Routingattribute { get; set; } = null!;

    public string Routingoperator { get; set; } = null!;

    public string Routingattributevalue { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;

    public string? Description { get; set; }

    public int Id { get; set; }
}
