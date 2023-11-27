using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Attachment
{
    public string Documentid { get; set; } = null!;

    public string Documenttype { get; set; } = null!;

    public byte[] Documentdata { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
