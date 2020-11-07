using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Miguel_P2_AP2.Models
{
    public class Cobros
    {
        [Key]
        public int CobroId { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public int Totales { get; set; }
        public double TotalCobrado { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("CobroId")]
        public virtual List<CobrosDetalle> CobrosDetalle { get; set; } = new List<CobrosDetalle>();

        public Cobros()
        {
            CobroId = 0;
            Fecha = DateTime.Now;
            ClienteId = 0;
            TotalCobrado = 0;
            Totales = 0;
            Observaciones = string.Empty;
        }
    }
}
    
