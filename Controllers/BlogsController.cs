using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VivesBlog.Models;

namespace VivesBlog.Controllers
{
    public class BlogsController : Controller
    {
        // GET
        public IActionResult Blogs()
        {
            var lijst = new List<Blog>(Blog.maakData());

            return View(lijst);
        }
    }
}