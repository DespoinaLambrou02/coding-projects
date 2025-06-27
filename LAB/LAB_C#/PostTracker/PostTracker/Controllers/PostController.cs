using Microsoft.AspNetCore.Mvc;
using PostTracker.models;
using System.Security.Policy;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PostTracker.Controllers
{
    public class PostController : Controller
    {
        DbPostsContext aDB = new DbPostsContext();
        public IActionResult Index(int? id)
        {
            if(id == null)
            {
                var AllPost = aDB.Posts.OrderByDescending(x => x.LastUpdated).ToList();
                return View(AllPost);

            }
            else
            {
                var AllPost = aDB.Posts.Where(x => x.IdSocialNetwork == id).OrderByDescending(x => x.LastUpdated).ToList();
                return View(AllPost);
            }
            


        }


        [HttpPost]
        public IActionResult Index(string SearchInput)
        {

            var AllPosts = aDB.Posts.ToList();
            List<Post> searchResults = new List<Post>();
            foreach (var aPost in AllPosts)
            {
                string aTitle = aPost.Title;
                aTitle = aTitle.ToLower();
                SearchInput = SearchInput.ToLower();
                bool result = aTitle.Contains(SearchInput);
                if (result)
                {
                    searchResults.Add(aPost);

                }


            }

            return View("Index",searchResults);

        }

        public IActionResult Edit(int id)
        {
            ViewModel2 aModel = new ViewModel2();
            var aPost = aDB.Posts.Find(id);
            aModel.aListOfString = theSocialNetworkProperties;
            aModel.SelectedPost = aPost;
            return View(aModel);
        }

        [HttpPost]
        public IActionResult Edit(Post NewPost)
        {

            aDB.Posts.Find(NewPost.IdPost).Published = NewPost.Published;
            aDB.Posts.Find(NewPost.IdPost).LastUpdated = NewPost.LastUpdated;
            aDB.SaveChanges();
            return RedirectToAction("Index");

        }




        public IActionResult Create()
        {
            var aList = aDB.SocialNetworks.ToList();
            return View(aList);
        }

        [HttpPost]
        public IActionResult Create(int? InputSelectedSocialNetwork, Post? NewPost)
        {
            if (InputSelectedSocialNetwork != null)
            {
                
                ViewModel aModel = new ViewModel();
                aModel.aListOfString = theSocialNetworkProperties;
                aModel.selectedValue = aDB.SocialNetworks.Find(InputSelectedSocialNetwork).NameSocialNetwork;
                return View("CreateForm", aModel);
                
            }
            else 
            {
                aDB.Posts.Add(NewPost);
                aDB.SaveChanges();

                return RedirectToAction("Index");
            }

            


        }


        public class ViewModel
        {
            public List<Dictionary<string, string>> aListOfString { get; set; }
            public string selectedValue { get; set; }
           
        }

        public class ViewModel2
        {
            public List<Dictionary<string, string>> aListOfString { get; set; }
            public Post SelectedPost { get; set; }

        }



        List<Dictionary<string, string>> theSocialNetworkProperties = new List<Dictionary<string, string>>
    {
        new Dictionary<string, string>
        {
            { "ID", "1" },
            { "NAME", "FACEBOOK" },
            { "DATE", "date" },
            { "TITLE", "text" },
            { "SCHEDULED", "date" },
            { "PUBLISHED", "date" },
            { "LASTUPDATED", "date" },
            { "REACH", "number" },
            { "REACTIONS", "number" },
            { "SHARES", "number" },
            { "COMMENTS", "number" },
            { "CLICKS", "number" }
        },

        new Dictionary<string, string>
        {
            { "ID", "2" },
            { "NAME", "INSTAGRAM" },
            { "DATE", "date" },
            { "TITLE", "text" },
            { "SCHEDULED", "date" },
            { "PUBLISHED", "date" },
            { "LASTUPDATED", "date" },
            { "REACH", "number" },
            { "SAVES", "NUMBER" },
            { "SHARES", "number" },
            { "COMMENTS", "number" },
            { "LIKES", "number" }

        },
        new Dictionary<string, string>
        {
            { "ID", "3" },
            { "NAME", "TIKTOK" },
            { "DATE", "date" },
            { "TITLE", "text" },
            { "SCHEDULED", "date" },
            { "PUBLISHED", "date" },
            { "LASTUPDATED", "date" },
            { "COMMENTS", "number" },
            { "LIKES", "number" },
            { "VIEWS", "number" }
        },
        new Dictionary<string, string>
        {
            { "ID", "4" },
            { "NAME", "LINKEDLN" },
            { "DATE", "date" },
            { "TITLE", "text" },
            { "SCHEDULED", "date" },
            { "PUBLISHED", "date" },
            { "LASTUPDATED", "date" },
            { "REACTIONS", "number" },
            { "COMMENTS", "number" },
            { "VIEWS", "number" }
        },
        new Dictionary<string, string>
        {
            { "ID", "5" },
            { "NAME", "NEWSLETTER" },
            { "DATE", "date" },
            { "TITLE", "text" },
            { "SCHEDULED", "date" },
            { "PUBLISHED", "date" },
            { "LASTUPDATED", "date" },
            { "CLICKS", "number" },
            { "DELIVERED", "number" },
            { "OPENED", "number" },
            { "UNSUBSCRIBES", "number" }
        },
        new Dictionary<string, string>
        {
            { "ID", "6" },
            { "NAME", "BLOG" },
            { "DATE", "date" },
            { "TITLE", "text" },
            { "SCHEDULED", "date" },
            { "PUBLISHED", "date" },
            { "LASTUPDATED", "date" },
            { "VIEWS", "number" }
        }
    };



  }


}
