using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Mapbitmap
{
    public string Mapname { get; set; } = null!;

    public string? Owner { get; set; }

    public string? Description { get; set; }

    public int? Xtopleft { get; set; }

    public int? Ytopleft { get; set; }

    public int? Xbottomleft { get; set; }

    public int? Ybottomleft { get; set; }

    public int? Xtopright { get; set; }

    public int? Ytopright { get; set; }

    public int? Xbottomright { get; set; }

    public int? Ybottomright { get; set; }

    public int? Projectiontype { get; set; }

    public int? Scale { get; set; }

    public int? Dpi { get; set; }

    public int? Xoffset { get; set; }

    public int? Yoffset { get; set; }

    public bool Ishome { get; set; }
}
