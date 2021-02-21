using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VivesBlog.Models
{
    public class Author
    {
        [DisplayName("Naam")]
        [Required(ErrorMessage = "Het veld {0} is verplicht.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Het veld {0} moet minimum 3 karakters en maximum 50 karakters lang zijn.")]
        public string Naam { get; set; }
        
        [DisplayName("Voornaam")]
        [Required(ErrorMessage = "Het veld {0} is verplicht.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Het veld {0} moet minimum 3 karakters en maximum 50 karakters lang zijn.")]
        public string Voornaam { get; set; }
        public int Id { get; set; }
    }
}