using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CrudOperationsInRazorPages.Models
{
    public class Books
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Book Title")]
        public string BookTitle { get; set; } = null!;

        [DisplayName("Book Description")]
        public string BookDescription { get; set; } = null!;

        [Required]
        public string Author { get; set; } = null!;
    }
}