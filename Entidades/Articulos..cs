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

        public string NombreArticulo { get; set; }

        public string MarcaUsuario { get; set; }

        public int PrecioArticulo { get; set; }

        public  int   CantidadArticulo { get; set; }

        public string Despcricion { get; set; }

        public DateTime FechaIngreso { get; set; }






    }
}
