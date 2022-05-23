using System.ComponentModel.DataAnnotations;

namespace book_store.API.Models
{
    public class User
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [StringLength(150)]
        public string FullName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }

    }
}
