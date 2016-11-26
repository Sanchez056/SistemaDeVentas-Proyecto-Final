using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using SistemaDeVentas.Entidades;

namespace Entidades
{
   public  class Compras
    {
    [Key]

        public int CompraId { get; set; }
        public string Codigo{ get; set; }
        public int Cantidad { get; set; }

        public double Itebis { get; set; }
        public double SubTotal { get; set; }
        public double TotalDescuento { get; set; }
        public double TotalItebis { get; set; }
        public double Total { get; set; }
        public DateTime Fecha { get; set; }
        public virtual List<Articulos> Articulos { get; set; }

        public Compras()
        {
            this.Articulos = new List<Articulos>();
        }


        // [Browsable(false)]
        public Compras(int compraId, string codigo, int Cantidad, double subTotal,double itebis, double totalDesuento, double totalItebis, double total, DateTime fecha)
        {

            this.CompraId = compraId;
            this.Codigo = codigo;
            this.SubTotal = subTotal;
            this.TotalDescuento = totalDesuento;
            this.TotalItebis = totalItebis;
            this.Total = total;
            this.Articulos = new List<Articulos>();
        }

    }
}
