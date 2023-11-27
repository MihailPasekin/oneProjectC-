using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Attributevalidator
{
    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Assemblydllpath { get; set; } = null!;

    public string Assemblydll { get; set; } = null!;

    public string Classname { get; set; } = null!;
}
