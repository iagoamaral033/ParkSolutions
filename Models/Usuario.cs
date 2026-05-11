namespace ParkSolutions.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public required string Email { get; set; } 
        public required string SenhaHash { get; set; }
        public string? GoogleId { get; set; }
        public bool Admin { get; set; }
    }   
}
