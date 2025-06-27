using System;
using System.Collections.Generic;

namespace PostTracker.models;




public partial class Post
{
    public int IdPost { get; set; }

    public int IdSocialNetwork { get; set; }

    public DateTime Date { get; set; }

    public string Title { get; set; } = null!;

    public int? Reach { get; set; }

    public int? Reactions { get; set; }

    public int? Shares { get; set; }

    public int? Comments { get; set; }

    public int? Clicks { get; set; }

    public DateTime Scheduled { get; set; }

    public DateTime? Published { get; set; }

    public DateTime LastUpdated { get; set; }

    public int? Likes { get; set; }

    public int? Saves { get; set; }

    public int? Delivered { get; set; }

    public int? Opened { get; set; }

    public int? Unsubscribes { get; set; }

    public int? Views { get; set; }

    public virtual SocialNetwork IdSocialNetworkNavigation { get; set; } = null!;

    public void correctPost()
    {
        if (IdSocialNetwork == 1)
        {
            Likes = 0;
            Saves = 0;
            Delivered = 0;
            Opened = 0;
            Unsubscribes = 0;
            Views = 0;
        }
        else if (IdSocialNetwork == 2)
        {
            Reactions = 0;
            Clicks = 0;
            Delivered = 0;
            Opened = 0;
            Unsubscribes = 0;
            Views = 0;

        }
        else if (IdSocialNetwork == 3)
        {
            Reach = 0;
            Reactions = 0;
            Shares = 0;
            Saves = 0;
            Delivered = 0;
            Opened = 0;
            Unsubscribes = 0;

        }
        else if (IdSocialNetwork == 4)
        {
            Reach = 0;
            Shares = 0;
            Clicks = 0;
            Likes = 0;
            Saves = 0;
            Delivered = 0;
            Opened = 0;
            Unsubscribes = 0;

        }
        else if (IdSocialNetwork == 5)
        {
            Reach = 0;
            Reactions = 0;
            Shares = 0;
            Comments = 0;
            Likes = 0;
            Saves = 0;
            Views = 0;

        }
        else if (IdSocialNetwork == 6)
        {
            Reach = 0;
            Reactions = 0;
            Shares = 0;
            Comments = 0;
            Clicks = 0;
            Likes = 0;
            Saves = 0;
            Delivered = 0;
            Opened = 0;
            Unsubscribes = 0;
        }
    }

    public void NullToZero(Post wrongPost)
    {
        
    }


}

   
     
