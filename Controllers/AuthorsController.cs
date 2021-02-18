using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VivesBlog.Core;
using VivesBlog.Models;

namespace VivesBlog.Controllers
{
    public class AuthorsController : Controller
    {
        
        private readonly IDatabase _database;

        public AuthorsController(IDatabase database)
        {
            _database = database;
        }
        public IList<Author> GetAuthors()
        {
            return _database.Authors;
        }
        
        
        public IActionResult Index()
        {
            return View(GetAuthors());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Author author)
        {
            author.Id = GetNewId();
            _database.Authors.Add(author);
            
            return RedirectToAction("Index");
        }

        private int GetNewId()
        {
            if (_database.Authors.Any())
            {
                var getMaxId = _database.Authors.Max(p => p.Id);
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
            var databaseAuthor = _database.Authors.SingleOrDefault(a => a.Id == id);

            return View(databaseAuthor);
        }

        [HttpPost]
        public IActionResult Edit(Author author)
        {
            var databaseAuthor = _database.Authors.SingleOrDefault(a => a.Id == author.Id);

            if (databaseAuthor == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                databaseAuthor.Naam = author.Naam;
                databaseAuthor.Voornaam = author.Voornaam;

                return RedirectToAction("Index");
            }

        }
        
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var databaseAuthor = _database.Authors.SingleOrDefault(a => a.Id == id);

            if (databaseAuthor == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                _database.Authors.Remove(databaseAuthor);
                return RedirectToAction("Index");
            }
        }
        
    }
}