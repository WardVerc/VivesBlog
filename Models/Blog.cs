using System.Collections.Generic;

namespace VivesBlog.Models
{
    public class Blog
    {
        public string Titel { get; set; }
        public string Inhoud { get; set; }
        
        public static IEnumerable<Blog> maakData()
        {
            var testBlog = new Blog() { Titel = "Titel van de eerste blog ", 
                Inhoud = "Wauwie dit is een mooie blog post. Hierin wil ik veel vertellen"
            };
            
            var testBlog2 = new Blog() { Titel = "ASP.NET is supertof ", 
                Inhoud = "Maar ik moet nog veel oefenen, is wel cool om te doen!"
            };
            
            var testBlog3 = new Blog() { Titel = "Joepie", 
                Inhoud = "Joepie, ik heb een nieuwe bureaustoel!"
            };
            
            var blogLijst = new List<Blog>();
            blogLijst.Add(testBlog);
            blogLijst.Add(testBlog2);
            blogLijst.Add(testBlog3);

            return blogLijst;
        }
    }
}