using System;
using System.Collections.Generic;

namespace PostTracker.models;

public partial class SocialNetwork
{
    public int IdSocialNtewok { get; set; }

    public string NameSocialNetwork { get; set; } = null!;

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}
