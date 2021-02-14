using System.Collections.Generic;
using VivesBlog.Models;

namespace VivesBlog.Core
{
    public interface IDatabase
    {
        IList<Blog> Blogs { get; set; }
        IList<Author> Authors { get; set; }
        void Initialize();
    }
}