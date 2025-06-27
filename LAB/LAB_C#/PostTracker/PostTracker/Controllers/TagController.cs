using Microsoft.AspNetCore.Mvc;
using PostTracker.models;

namespace PostTracker.Controllers
{
    public class TagController : Controller
    {
        DbPostsContext aDB = new DbPostsContext();
        public IActionResult Index()
        {
            var AllTags = aDB.Tags.ToList();
            return View(AllTags);
        }

        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(string newTagName)
        {
            Tag aTag = new Tag { TitleTag = newTagName };
            aDB.Tags.Add(aTag);
            aDB.SaveChanges();
            return RedirectToAction("Index");
        }




        public IActionResult Edit(int id)
        {
            var aTag = aDB.Tags.Find(id);
            return View(aTag);
        }

        [HttpPost]
        public IActionResult Edit(string newTagName, int tagID)
        {
            aDB.Tags.Find(tagID).TitleTag = newTagName;
            aDB.SaveChanges();
            return RedirectToAction("Index"); 
        }

    }


   
}
