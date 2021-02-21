using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VivesBlog.Models
{
    public class Blog
    {
        [DisplayName("Titel")]
        [Required(ErrorMessage = "Het veld {0} is verplicht.")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Het veld {0} moet minimum 3 karakters en maximum 10 karakters lang zijn.")]
        public string Titel { get; set; }
        
        [DisplayName("Inhoud")]
        [Required(ErrorMessage = "Het veld {0} is verplicht.")]
        [StringLength(255, ErrorMessage = "Het veld {0} mag maximum 255 karakters lang zijn.")]
        public string Inhoud { get; set; }
        public int Id { get; set; }
        
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        
    }
}