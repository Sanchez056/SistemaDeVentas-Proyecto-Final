using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
   public  class Compras
    {
    [Key]

        public int CompraId { get; set; }
        public string codigoCompra{ get; set; }
        public double Cantidad { get; set; }
        public double Precio{ get; set; }
        public double Itebis { get; set; }
        public double SubTotal { get; set; }
        public double Total { get; set; }
        public DateTime Fecha { get; set; }

        public DateTime Hora { get; set; }

    }
}
