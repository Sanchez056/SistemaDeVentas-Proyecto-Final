﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
   public  class TiposUsuarios
    {
        [Key]
        public int UsuarioId{ get; set; }
        public string Detalle{ get; set; }

       

        

        public override string ToString()
        {
            return this.Detalle;
        }

    }
}
