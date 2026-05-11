namespace ParkSolutions.Models
{
    public class Configuracao
    {
        public int Id { get; set; }
        public string NomeEstacionamento { get; set; } = string.Empty;
        public string Cnpj { get; set; } = string.Empty;
        public int Capacidade { get; set; }
        public string Notificacao { get; set; } = string.Empty;

    }
}
