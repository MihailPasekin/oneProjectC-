using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Processvalidator
{
    public string Processid { get; set; } = null!;

    public string? Processname { get; set; }

    public string? Validationexpression { get; set; }
}
