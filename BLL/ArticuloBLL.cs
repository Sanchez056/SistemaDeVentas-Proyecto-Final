using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

using Entidades;


namespace BLL
{
    public class ArticuloBLL
    {
        Articulos articulos= new Articulos();

        public static void Insertar(Articulos a)
        {

            try
            {

                using (var db = new SistemaVentasDb())
                {

                    db.Articulos.Add(a);
                    db.SaveChanges();
                    db.Dispose();

                }


            }
            catch (Exception e)
            {
                throw e;

            }

        }

        public static Articulos Buscar(int id)
        {
            var db = new SistemaVentasDb();

            return db.Articulos.Find(id);


        }

        public static void Modificar(int id, Articulos articulo)
        {
            var db = new SistemaVentasDb();

            Articulos a = db.Articulos.Find(id);
            a.NombreArticulo = articulo.NombreArticulo;
            a.MarcaArticulo = articulo.MarcaArticulo;
            a.CodigoArticulo = articulo.CodigoArticulo;
            a.CantidadArticulo = articulo.CantidadArticulo;
            a.Despcricion = articulo.Despcricion;
            a.PrecioCompraArticulo = articulo.PrecioCompraArticulo;
            a.NombreProveedor= articulo.NombreProveedor;
            db.SaveChanges();
        }

        public static void Eliminar(int id)
        {
            var db = new SistemaVentasDb();
            Articulos a = db.Articulos.Find(id);

            db.Articulos.Remove(a);
            db.SaveChanges();
        }


        public static List<Articulos> GetLista()
        {
            List<Articulos> lista = new List<Articulos>();

            var db = new SistemaVentasDb();

            lista = db.Articulos.ToList();

            return lista;


        }

        public static List<Articulos> GetLista(int articuloId)
        {
            List<Articulos> lista = new List<Articulos>();

            var db = new SistemaVentasDb();

            lista = db.Articulos.Where(p => p.ArticuloId == articuloId).ToList();

            return lista;

        }



        public static List<Articulos> GetListaNombreArticulo(string aux)
        {
            List<Articulos> lista = new List<Articulos>();

            var db = new SistemaVentasDb();

            lista = db.Articulos.Where(p => p.NombreArticulo== aux).ToList();

            return lista;

        }
        public static List<Articulos> GetListaMarcaArticulo(string aux)
        {
            List<Articulos> lista = new List<Articulos>();

            var db = new SistemaVentasDb();

            lista = db.Articulos.Where(p => p.MarcaArticulo== aux).ToList();

            return lista;

        }

        public static List<Articulos> GetListaCodigoArticulo(string aux)
        {
            List<Articulos> lista = new List<Articulos>();

            var db = new SistemaVentasDb();

            lista = db.Articulos.Where(p => p.CodigoArticulo== aux).ToList();

            return lista;

        }

    }
}
