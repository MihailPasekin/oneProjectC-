using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Parallelpickdetail
{
    public string Parallelpickid { get; set; } = null!;

    public string Picklist { get; set; } = null!;

    public int Picklistseq { get; set; }
}
