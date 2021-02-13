using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VivesBlog.Core;
using VivesBlog.Models;

namespace VivesBlog.Controllers
{
    public class BlogsController : Controller
    {
        private readonly IDatabase _database;

        public BlogsController(IDatabase database)
        {
            _database = database;
        }
        public IActionResult Index()
        {
            var lijst = GetBlogs();

            return View(lijst);
        }

        public IList<Blog> GetBlogs()
        {
            return _database.Blogs;
        }
    }
}