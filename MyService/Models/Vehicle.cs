namespace MyService.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        public string? RegistrationNumber { get; set; }

        public string? Type { get; set; }

        public string? Brand { get; set; }

        public string? Model { get; set; }

        public decimal? HasAssembly { get; set; }

        public decimal? HasDisassembly { get; set; }

        public decimal? HasRust { get; set; }

        public decimal? Silicone { get; set; }

        public decimal Work { get; set; }

        public decimal? Molding { get; set; }

        public decimal? Consumables { get; set; }

        public string? Description { get; set; }

        public decimal FinalPrice { get; set; }

        public string? Photo { get; set; }

        public int ClientId { get; set; }

        [ForeignKey(nameof(ClientId))]
        public Client Client { get; set; } = null!;

    }
}
