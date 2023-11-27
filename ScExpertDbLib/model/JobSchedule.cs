using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class JobSchedule
{
    public string Name { get; set; } = null!;

    public string AssemblyDll { get; set; } = null!;

    public string ClassName { get; set; } = null!;

    public string? Arguments { get; set; }

    public string Description { get; set; } = null!;

    public int Interval { get; set; }

    public DateTime LastRun { get; set; }

    public string? LastStatus { get; set; }

    public string? LastLog { get; set; }

    public bool Running { get; set; }

    public bool Enabled { get; set; }
}
