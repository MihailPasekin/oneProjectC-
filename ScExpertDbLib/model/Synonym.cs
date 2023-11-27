using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Synonym
{
    public string OrgWord { get; set; } = null!;

    public string Trans { get; set; } = null!;
}
