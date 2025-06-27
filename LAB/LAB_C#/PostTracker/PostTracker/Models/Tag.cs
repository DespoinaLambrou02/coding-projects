using System;
using System.Collections.Generic;

namespace PostTracker.models;

public partial class Tag
{
    public int IdTag { get; set; }

    public string TitleTag { get; set; } = null!;
}
