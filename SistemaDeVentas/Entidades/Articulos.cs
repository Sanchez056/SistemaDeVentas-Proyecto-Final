using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeVentas.Entidades
{
   public  class Articulos
    {
        [Key]

        public int ArticuloId{ get; set; }


        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Marca { get; set; }

        public DateTime Fecha { get; set; }

    }
}
