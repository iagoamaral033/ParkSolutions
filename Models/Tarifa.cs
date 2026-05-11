namespace ParkSolutions.Models
{
    public class Tarifa
    {
        public int Id { get; set; }
        public required string TipoVeiculo { get; set; }
        public decimal ValorHora { get; set; }
        public decimal DiariaMaxima { get; set;} 
        public int ToleranciaMinutos { get; set; } 
    }
}
