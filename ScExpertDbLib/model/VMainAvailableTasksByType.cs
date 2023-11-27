using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VMainAvailableTasksByType
{
    public string Task { get; set; } = null!;

    public string Tasktype { get; set; } = null!;

    public string Status { get; set; } = null!;
}
