using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VivesBlog.Models
{
    public class Blog
    {
        [DisplayName("Titol")]
        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string Titel { get; set; }
        
        
        public string Inhoud { get; set; }
        public int Id { get; set; }
        
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        
    }
}