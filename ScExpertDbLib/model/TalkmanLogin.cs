using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class TalkmanLogin
{
    public string Username { get; set; } = null!;

    public string? Location { get; set; }

    public string? Hetype { get; set; }

    public string? Mheid { get; set; }

    public int Language { get; set; }
}
