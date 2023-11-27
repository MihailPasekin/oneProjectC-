using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Loadsaccessibility
{
    public string Loadid { get; set; } = null!;

    public int? Accessibility { get; set; }
}
