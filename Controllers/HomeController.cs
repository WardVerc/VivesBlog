using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VivesBlog.Models;

namespace VivesBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var blogLijst = new List<Blog>(Blog.maakData());

            return View(blogLijst);
        }

        public IActionResult Read(int id)
        {
            var blogLijst = new List<Blog>(Blog.maakData());
            
            // SingleOrDefault(): selecteer het enige element van de lijst dat voldoet aan de criteria
            // dit geval: als het id gelijk is aan het meegegeven id
            var blog = blogLijst.SingleOrDefault(foo => foo.Id == id);

            if (blog == null)
            {
                return RedirectToAction("Index");
            }

            return View(blog);
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}