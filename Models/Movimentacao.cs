namespace ParkSolutions.Models
{
    public class Movimentacao
    {
        public int Id { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime? Saida { get; set; }
        public decimal ValorCobrado { get; set; }
        public required string DuracaoFormatada { get; set; } = string.Empty;
    }
}
