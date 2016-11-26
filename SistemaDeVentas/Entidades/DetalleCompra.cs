using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Entidades;

namespace SistemaDeVentas.Entidades
{
    public class DetalleCompra
    {
        [Key]
        public int DetelleCompraId { get; set; }
        public int CompraId { get; set; }

        public int ArticuloId { get; set; }

        public virtual List<Compras> Compras { get; set; }
        public virtual List<Articulos> Articulos { get; set; }
    }
}
