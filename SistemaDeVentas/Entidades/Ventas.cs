using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeVentas.Entidades
{
   public  class Ventas
    {
        [Key]
        public int VentaId { get; set; }

        public string CodigoVenta { get; set; }

        public string NombreCliente { get; set; }

        public int Descuento{ get; set; }

        public int Itebis{ get; set; }

        public int SubTotal { get; set; }

        public int Total { get; set; }

        public DateTime Fecha{ get; set; }

        public DateTime Hora { get; set; }

        public virtual List<Articulos> Articulos { get; set; }
        public Ventas()
        {
            this.Articulos= new List<Articulos>();
        }


        // [Browsable(false)]
        public Ventas(int VentaId, string codigoVenta,int  cantidad, int descuento)
        {

            this.VentaId = VentaId;
            this.CodigoVenta = codigoVenta;
            this.Articulos = new List<Articulos>();
        }

    }
}
