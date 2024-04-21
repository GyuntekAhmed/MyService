namespace MyService.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set;} = null!;

        public string? Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; } = null!;
    }
}
