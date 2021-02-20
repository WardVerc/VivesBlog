using System.Collections.Generic;
using VivesBlog.Models;

namespace VivesBlog.ViewModels
{
    public class BlogAuthorViewModel
    {
        public Blog Blog { get; set; }
        public IList<Author> Authors { get; set; }
    }
}