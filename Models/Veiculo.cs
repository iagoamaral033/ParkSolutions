using System.Diagnostics.Contracts;

namespace ParkSolutions.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; } = string.Empty;
        public string Proprietario { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public string Cor { get; set; } = string.Empty;
        public string CorHex { get; set; } = string.Empty;
        public bool Mensalista { get; set; }

    }
}
