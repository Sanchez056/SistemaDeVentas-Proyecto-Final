using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Entidades;

namespace SistemaDeVentas.Entidades
{
    public class DetalleVentas
    {
        [Key]
        public int DetelleVenta { get; set; }
        public int VentaId { get; set; }

        public int ClienteId { get; set; }

        public int EmpleadoId { get; set; }
        public int ArticuloId { get; set; }

        public virtual List<Ventas> Ventas { get; set; }
        public virtual List<Clientes> Clientes { get; set; }

        public virtual List<Empleados> Empleados { get; set; }
        public virtual List<Articulos> Articulos { get; set; }




    }
}
