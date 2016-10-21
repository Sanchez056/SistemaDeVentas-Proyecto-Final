using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace BLL
{
   public  class GaranteBLL
    {
        Garantes garantes = new Garantes();

        public static void Insertar(Garantes g)
        {

            try
            {

                using (var db = new SistemaVentasDb())
                {

                    db.Gerantes.Add(g);
                    db.SaveChanges();
                    db.Dispose();

                }


            }
            catch (Exception e)
            {
                throw e;

            }

        }

        public static Garantes Buscar(int id)
        {
            var db = new SistemaVentasDb();

            return db.Gerantes.Find(id);


        }

        public static void Eliminar(int id)
        {
            var db = new SistemaVentasDb();
            Garantes g = db.Gerantes.Find(id);

            db.Gerantes.Remove(g);
            db.SaveChanges();
        }


        public static List<Garantes> GetLista()
        {
            List<Garantes> lista = new List<Garantes>();

            var db = new SistemaVentasDb();

            lista = db.Gerantes.ToList();

            return lista;


        }

        public static List<Garantes> GetLista(int garanteId)
        {
            List<Garantes> lista = new List<Garantes>();

            var db = new SistemaVentasDb();

            lista = db.Gerantes.Where(p => p.GeranteId == garanteId).ToList();

            return lista;

        }



        public static List<Garantes> GetListaCedula(string aux)
        {
            List<Garantes> lista = new List<Garantes>();

            var db = new SistemaVentasDb();

            lista = db.Gerantes.Where(p => p.Celula== aux).ToList();

            return lista;

        }

    }
}
