using System.ComponentModel.DataAnnotations;

namespace Miguel_P2_AP2.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
    }
}