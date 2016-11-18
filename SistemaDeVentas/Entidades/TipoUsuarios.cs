using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
   public  class TipoUsuarios
    {
        [Key]
        public int TipoUsuarioId{ get; set; }
        public string Detalle{ get; set; }

       

        

        /*public override string ToString()
        {
            return this.Detalle;
        }*/

    }
}
