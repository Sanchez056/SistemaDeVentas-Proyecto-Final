using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
using SistemaDeVentas.Entidades;

namespace SistemaDeVentas.BLL
{
   public  class CompraBLL
    {
        Compras compra = new Compras();

        public static bool Insertar(Compras c)
        {
            //  bool retorna = false;

            try
            {

                using (var db = new SistemaVentasDb())
                {

                    db.Compras.Add(c);
                    db.SaveChanges();
                    db.Dispose();
                    // retorna= true;
                    return true;

                }


            }
            catch (Exception)
            {
                return false;
                throw;

            }

            // return retorna;

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

