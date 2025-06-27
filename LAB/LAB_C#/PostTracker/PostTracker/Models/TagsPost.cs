using System;
using System.Collections.Generic;

namespace PostTracker.models;

public partial class TagsPost
{
    public int IdPost { get; set; }

    public int IdTag { get; set; }

    public virtual Post IdPostNavigation { get; set; } = null!;

    public virtual Tag IdTagNavigation { get; set; } = null!;
}
