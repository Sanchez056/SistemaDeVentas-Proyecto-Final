namespace SistemaDeVentas
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Articulos> Articulos { get; set; }
        public virtual DbSet<CiudadCliente> CiudadCliente { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Compras> Compras { get; set; }
        public virtual DbSet<Garantes> Garantes { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<TipoUsuarios> TipoUsuarios { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articulos>()
                .Property(e => e.CodigoArticulo)
                .IsUnicode(false);

            modelBuilder.Entity<Articulos>()
                .Property(e => e.NombreArticulo)
                .IsUnicode(false);

            modelBuilder.Entity<Articulos>()
                .Property(e => e.MarcaArticulo)
                .IsUnicode(false);

            modelBuilder.Entity<Articulos>()
                .Property(e => e.NombreProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<Articulos>()
                .Property(e => e.Despcricion)
                .IsUnicode(false);

            modelBuilder.Entity<CiudadCliente>()
                .Property(e => e.CiudadCliente1)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Sexo)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Cedula)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Compras>()
                .Property(e => e.NombreArticulo)
                .IsUnicode(false);

            modelBuilder.Entity<Compras>()
                .Property(e => e.MarcaArticulo)
                .IsUnicode(false);

            modelBuilder.Entity<Garantes>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Garantes>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Garantes>()
                .Property(e => e.Sexo)
                .IsUnicode(false);

            modelBuilder.Entity<Garantes>()
                .Property(e => e.Cedula)
                .IsUnicode(false);

            modelBuilder.Entity<Garantes>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<Garantes>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Garantes>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Garantes>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores>()
                .Property(e => e.NombreProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<TipoUsuarios>()
                .Property(e => e.Detalle)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.NombreUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Contrasena)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Tipo)
                .IsUnicode(false);
        }
    }
}
