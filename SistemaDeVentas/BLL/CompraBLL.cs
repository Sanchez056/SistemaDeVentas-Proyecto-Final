using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
using SistemaDeVentas.Entidades;
using System.Data.Entity;

namespace SistemaDeVentas.BLL
{
   public  class CompraBLL
    {
        Compras compra = new Compras();

        public static bool Insertar(Compras c)
        {
            bool re = false;
            try
            {
                var db = new SistemaVentasDb();

                db.Compras.Add(c);
                var gp = db.Compras.Add(c);
                foreach (var art in c.Articulos)
                {
                    db.Entry(art).State = EntityState.Unchanged;
                }
                db.SaveChanges();
                db.Dispose();
                re = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return re;


        }
        public static bool Modificar(int id, Compras com)
        {
            bool retorno = false;
            try
            {
                using (var db = new SistemaVentasDb())
                {
                    Compras c = db.Compras.Find(id);
                    c.Codigo = com.Codigo;
                    c.Itebis = com.Itebis;
                    c.Cantidad = com.Cantidad;
                    
                    
                    db.SaveChanges();
                }
                retorno = true;
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }


        public static Compras Buscar(int id)
        {
            var db = new SistemaVentasDb();

            return db.Compras.Find(id);


        }



        public static bool Eliminar(int id)
        {
            //bool retorna = false;
            try
            {

                using (var db = new SistemaVentasDb())
                {
                    Compras c = new Compras();
                    c = db.Compras.Find(id);

                    db.Compras.Remove(c);
                    db.SaveChanges();
                    //db.Dispose();
                    return false;
                }


            }
            catch (Exception)
            {
                return true;
                throw;


            }

        }




        public static List<Compras> GetLista()
        {
            List<Compras> lista = new List<Compras>();

            var db = new SistemaVentasDb();

            lista = db.Compras.ToList();

            return lista;


        }



        public static List<Compras> GetLista(int id)
        {
            List<Compras> lista = new List<Compras>();

            var db = new SistemaVentasDb();

            lista = db.Compras.Where(p => p.CompraId == id).ToList();

            return lista;

        }



        public static List<Compras> GetListaCodigo(string aux)
        {
            List<Compras> lista = new List<Compras>();

            var db = new SistemaVentasDb();

            lista = db.Compras.Where(p => p.Codigo== aux).ToList();

            return lista;

        }





        public static List<Compras> GetListaFecha(DateTime aux)
        {
            List<Compras> lista = new List<Compras>();

            var db = new SistemaVentasDb();

            lista = db.Compras.Where(p => p.Fecha == aux).ToList();

            return lista;

        }
        public static List<Compras> GetListaFecha(DateTime Desde, DateTime Hasta)
        {
            List<Compras> lista = new List<Compras>();

            var db = new SistemaVentasDb();

            lista = db.Compras.Where(p => p.Fecha >= Desde && p.Fecha <= Hasta).ToList();

            return lista;

        }

    }
}

