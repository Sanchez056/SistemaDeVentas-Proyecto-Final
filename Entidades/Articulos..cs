using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Articulos
    {
        [Key]
        public int ArticuloId{ get; set; }

        public string CodigoArticulo { get; set; }

        public string NombreArticulo { get; set; }

        public string MarcaArticulo{ get; set; }

        public string NombreProveedor { get; set; }

        public int PrecioCompraArticulo { get; set; }

        public int PrecioVentaArticulo { get; set; }
        public  int  CantidadArticulo { get; set; }

        public string Despcricion { get; set; }

        //public DateTime FechaIngreso { get; set; }
        






    }
}
