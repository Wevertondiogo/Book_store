using System.ComponentModel.DataAnnotations;

namespace book_store.API.Data.Dtos.User
{
    public class ReadUserDTO
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [StringLength(150)]
        public string FullName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
    }
}
