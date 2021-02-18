using System.Collections.Generic;
using System.Linq;
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

        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            //niet zeker waarom ik AuthorId nog eens apart bijhou
            blog.AuthorId = blog.Author.Id;
            blog.Id = GetNewId();
            _database.Blogs.Add(blog);
            
            return RedirectToAction("Index");
        }

        private int GetNewId()
        {
            if (_database.Blogs.Any())
            {
                var getMaxId = _database.Blogs.Max(p => p.Id);
                return getMaxId += 1;
            }
            else
            {
                return 1;
            }
        }
        
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var databaseBlog = _database.Blogs.SingleOrDefault(b => b.Id == id);

            return View(databaseBlog);
        }

        [HttpPost]
        public IActionResult Edit(Blog blog)
        {
            var databaseBlog = _database.Blogs.SingleOrDefault(b => b.Id == blog.Id);

            if (databaseBlog == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                databaseBlog.Author = blog.Author;
                databaseBlog.Titel = blog.Titel;
                databaseBlog.Inhoud = blog.Inhoud;
                databaseBlog.AuthorId = blog.AuthorId;

                return RedirectToAction("Index");
            }

        }
        
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var databaseBlog = _database.Blogs.SingleOrDefault(b => b.Id == id);

            if (databaseBlog == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                _database.Blogs.Remove(databaseBlog);
                return RedirectToAction("Index");
            }
        }
        
    }
}