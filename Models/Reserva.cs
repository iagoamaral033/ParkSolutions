namespace ParkSolutions.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public required string VeiculoId { get; set; }
        public required string VagaId  { get; set; }
        public required string UsuarioID { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; } 
        public string Status { get; set; } = string.Empty;

    }
}