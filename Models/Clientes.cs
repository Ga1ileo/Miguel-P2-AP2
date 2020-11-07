using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Miguel_P2_AP2.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombres { get; set; }

        [ForeignKey("ClienteId")]
        public virtual List<Ventas> venta { get; set; }
    }
}