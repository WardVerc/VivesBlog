using System.Collections.Generic;

namespace VivesBlog.Models
{
    public class Blog
    {
        public string Titel { get; set; }
        public string Inhoud { get; set; }
        
        public int Id { get; set; }
        
        public static IEnumerable<Blog> maakData()
        {
            var testBlog = new Blog() { Titel = "Titel van de eerste blog ", 
                Inhoud = "Wauwie dit is een mooie blog post. Hierin wil ik veel vertellen",
                Id = 1
            };
            
            var testBlog2 = new Blog() { Titel = "ASP.NET is supertof ", 
                Inhoud = "Maar ik moet nog veel oefenen, is wel cool om te doen!",
                Id = 2
            };
            
            var testBlog3 = new Blog() { Titel = "Joepie", 
                Inhoud = "Joepie, ik heb een nieuwe bureaustoel!",
                Id = 3
            };
            
            var blogLijst = new List<Blog>();
            blogLijst.Add(testBlog);
            blogLijst.Add(testBlog2);
            blogLijst.Add(testBlog3);

            return blogLijst;
        }
    }
}