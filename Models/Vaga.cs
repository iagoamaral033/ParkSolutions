namespace ParkSolutions.Models
{
    public class Vaga
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public bool Coberta { get; set; } 

    }
}
