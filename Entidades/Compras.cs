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
        public string NombreArticulo { get; set; }
        public string MarcaArticulo{ get; set; }
        public float Cantidad { get; set; }
        public float Precio{ get; set; }
        public float Itebis { get; set; }
        public float Total { get; set; }
        public DateTime Fecha { get; set; }

    }
}
