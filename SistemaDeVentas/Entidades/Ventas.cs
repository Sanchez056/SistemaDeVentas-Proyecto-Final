using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeVentas.Entidades
{
   public  class Ventas
    {
        [Key]
        public int VentaId { get; set; }

        public string CodigoVenta { get; set; }

        public string NombreCliente { get; set; }

        public int Descuento{ get; set; }

        public int Itebis{ get; set; }

        public int SubTotal { get; set; }

        public int Total { get; set; }

        public DateTime Fecha{ get; set; }

        public DateTime Hora { get; set; }

    }
}
