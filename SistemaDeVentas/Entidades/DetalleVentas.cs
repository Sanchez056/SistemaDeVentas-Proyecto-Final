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
        public int DetelleVentaId { get; set; }
        public int VentaId { get; set; }

        public int ArticuloId { get; set; }

        public virtual List<Ventas> Ventas { get; set; }
        public virtual List<Articulos> Articulos { get; set; }




    }
}
