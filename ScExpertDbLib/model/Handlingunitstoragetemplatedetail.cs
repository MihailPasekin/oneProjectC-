using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Handlingunitstoragetemplatedetail
{
    public string Hustoragetemplateid { get; set; } = null!;

    public int Hustoragetemplateline { get; set; }

    public string Handlingunit { get; set; } = null!;

    public int Handlingunitqty { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
