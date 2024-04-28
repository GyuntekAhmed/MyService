namespace MyService.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [Required(ErrorMessage ="Името е задължително!")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage ="Телефонният номер е задължителен!")]
        public string PhoneNumber { get; set; } = null!;

        public string? RegistrationNumber { get; set; }

        public string? Brand { get; set; }

        public string? Model { get; set; }

        public decimal? Assembly { get; set; }

        public decimal? Disassembly { get; set; }

        public decimal? Rust { get; set; }

        public decimal? Silicone { get; set; }

        public decimal Work { get; set; }

        public decimal? Molding { get; set; }

        public decimal? Consumables { get; set; }

        public string? Description { get; set; }

        public Image? Photo { get; set; }

        public decimal FinalPrice
        {
            get
            {
                return (Assembly ?? 0) + (Disassembly ?? 0) + (Rust ?? 0) +
                       (Silicone ?? 0) + Work + (Molding ?? 0) + (Consumables ?? 0);
            }
        }
    }
}
