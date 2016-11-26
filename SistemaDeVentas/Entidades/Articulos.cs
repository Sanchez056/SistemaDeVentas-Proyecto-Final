using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Entidades;
using System.ComponentModel;

namespace SistemaDeVentas.Entidades
{
    public class Articulos
    {
        [Key]

        public int ArticuloId { get; set; }


        public string Codigo { get; set; }

        public string Nombre { get; set; }

         [Browsable(false)]
        public string Descripcion { get; set; }

        public string Marca { get; set; }

        [Browsable(false)]
        public string NombreProveedor { get; set; }

        [Browsable(false)]
        public string Categoria { get; set; }

        public int Cantidad { get; set; }

        public double Descuento { get; set; }

         [Browsable(false)]
        public double PrecioCompra { get; set; }

        public double PrecioVentas { get; set; }

        public double  Total { get; set; }



        [Browsable(false)]
        public DateTime Fecha { get; set; }

        //------------------------
        public virtual List<Ventas> Ventas { get; set; }
        public virtual List<Compras> Compras { get; set; }


        public Articulos()
        {
            this.Ventas = new List<Ventas>();
            this.Compras = new List<Compras>();

        }


        public Articulos(int articuloId,string codigo,string nombre,string marca,double precio)
        {
            this.ArticuloId = articuloId;
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Marca = marca;
           // this.Cantidad = cantidad;
           // this.Descuento = descuento;
            this.PrecioVentas = precio;
            this.Ventas = new List<Ventas>();
            this.Compras = new List<Compras>();


        }
       


    }
}

