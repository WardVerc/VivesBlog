using System.Collections.Generic;
using VivesBlog.Models;

namespace VivesBlog.Core
{
    public class Database : IDatabase
    {
        public IList<Blog> Blogs { get; set; }

        public Database()
        {
            Blogs = new List<Blog>();
        }

        public void Initialize()
        {
            Blogs = new List<Blog>
            {
                new Blog
                {
                    Titel = "Titel van de eerste blog ",
                    Inhoud = "Wauwie dit is een mooie blog post. Hierin wil ik veel vertellen",
                    Id = 1
                },
                new Blog
                {
                    Titel = "ASP.NET is supertof ",
                    Inhoud = "Maar ik moet nog veel oefenen, is wel cool om te doen!",
                    Id = 2
                },
                new Blog
                {
                    Titel = "Joepie",
                    Inhoud = "Joepie, ik heb een nieuwe bureaustoel!",
                    Id = 3
                }
            };
        }
    }
}