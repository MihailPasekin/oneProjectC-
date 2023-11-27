using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Handlingunitstoragetemplate
{
    public string Hustoragetemplateid { get; set; } = null!;

    public string Hustoragetemplatename { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
