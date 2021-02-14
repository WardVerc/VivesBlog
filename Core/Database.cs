using System.Collections.Generic;
using VivesBlog.Models;

namespace VivesBlog.Core
{
    public class Database : IDatabase
    {
        public IList<Blog> Blogs { get; set; }
        public IList<Author> Authors { get; set; }

        public Database()
        {
            Blogs = new List<Blog>();
            Authors = new List<Author>();
        }

        public void Initialize()
        {
            
            var ward = new Author
            {
                Naam = "Vercruyssen", Voornaam = "Ward", Id = 1
            };
            var michiel = new Author
            {
                Naam = "Demoor", Voornaam = "Michiel", Id = 2
            };
            var filip = new Author
            {
                Naam = "De Feyter", Voornaam = "Filip", Id = 3
            };

            Authors.Add(ward);
            Authors.Add(michiel);
            Authors.Add(filip);
            
        
            Blogs = new List<Blog>
            {
                new Blog
                {
                    Titel = "Titel van de eerste blog ",
                    Inhoud = "Wauwie dit is een mooie blog post. Hierin wil ik veel vertellen",
                    Id = 1,
                    Author = ward,
                    AuthorId = ward.Id
                },
                new Blog
                {
                    Titel = "ASP.NET is supertof ",
                    Inhoud = "Maar ik moet nog veel oefenen, is wel cool om te doen!",
                    Id = 2,
                    Author = michiel,
                    AuthorId = michiel.Id
                },
                new Blog
                {
                    Titel = "Joepie",
                    Inhoud = "Joepie, ik heb een nieuwe bureaustoel!",
                    Id = 3,
                    Author = filip,
                    AuthorId = filip.Id
                }
            };
        }
    }
}