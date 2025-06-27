using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PostTracker.models;
using PostTracker.Models;

namespace PostTracker.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    DbPostsContext aDB = new DbPostsContext();

    public IActionResult Index()
    {
        ViewModel aModel = new ViewModel();
        DateTime today = DateTime.Today;
        DateTime sevenDaysAgo = today.AddDays(-6);
        aModel.PostsToday = aDB.Posts.Where(x => x.Scheduled == today).ToList();
        aModel.PostsExpired = aDB.Posts.Where(x => x.Published == null).ToList();
        aModel.PostsThisWeek = aDB.Posts.Where(x => x.Scheduled <= today && x.Scheduled >= sevenDaysAgo).ToList();
        return View(aModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public class ViewModel
    {
        public List<Post> PostsToday { get; set; }

        public List<Post> PostsExpired { get; set; }

        public List<Post> PostsThisWeek { get; set; }



    }
}
