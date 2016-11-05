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
        public virtual DbSet<Articulos> Articulos { get; set; }
        public virtual DbSet<Clientes>  Clientes { get; set; }
        public virtual DbSet<Garantes> Garantes { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }

        public virtual DbSet<TipoUsuarios> TipoUsuarios { get; set; }

        public virtual DbSet<Empleados> Empleados{ get; set; }

        public virtual DbSet<CategoriaArticulos> CategoriaArticulos { get; set; }



    }
}


   
