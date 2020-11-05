using System;
using System.ComponentModel.DataAnnotations;

namespace Miguel_P2_AP2.Models
{
    public class Ventas
    {
        [Key]
        public int VentaId { get; set; }

        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public double Monto { get; set; }
        public double Balance { get; set; }
    }
}