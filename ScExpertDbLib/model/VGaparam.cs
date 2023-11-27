using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VGaparam
{
    public int Numberofgenes { get; set; }

    public int Generations { get; set; }

    public int Populationsize { get; set; }

    public int Generationlimitwithoutprogress { get; set; }

    public int Groupsize { get; set; }

    public int Maxthelastbest { get; set; }

    public int Gentune { get; set; }

    public int Civilizations { get; set; }
}
