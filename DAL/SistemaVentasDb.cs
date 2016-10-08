using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;

namespace DAL
{
    public class SistemaVentasDb :DbContext
    {
      public  SistemaVentasDb() : base("name=ConStr")
        {

        }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<TiposUsuarios> TipoUsuario{ get; set; }
      
    }
}


   
