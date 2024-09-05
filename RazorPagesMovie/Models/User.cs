using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class User
    {
        public int? Id { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }
    }
}
