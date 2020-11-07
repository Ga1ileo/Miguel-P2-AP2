using System;
using System.ComponentModel.DataAnnotations;

namespace Miguel_P2_AP2.Models
{
    public class CobrosDetalle
    {
        [Key]
        public int CobroDetalleId { get; set; }
        public int CobroId { get; set; }
        public virtual Cobros Cobro { get; set; }
        public int VentaId { get; set; }
        public virtual Ventas Venta { get; set; }
        public double Cobrado { get; set; }

        public CobrosDetalle()
        {
            CobroDetalleId = 0;
            CobroId = 0;
            VentaId = 0;
            Cobrado = 0;
        }
    }
}