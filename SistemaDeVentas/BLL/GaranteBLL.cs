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

                    db.Garantes.Add(g);
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

            return db.Garantes.Find(id);


        }

        public static void Eliminar(int id)
        {
            var db = new SistemaVentasDb();
            Garantes g = db.Garantes.Find(id);

            db.Garantes.Remove(g);
            db.SaveChanges();
        }


        public static List<Garantes> GetLista()
        {
            List<Garantes> lista = new List<Garantes>();

            var db = new SistemaVentasDb();

            lista = db.Garantes.ToList();

            return lista;


        }

        public static List<Garantes> GetLista(int garanteId)
        {
            List<Garantes> lista = new List<Garantes>();

            var db = new SistemaVentasDb();

            lista = db.Garantes.Where(p => p.GaranteId == garanteId).ToList();

            return lista;

        }



        public static List<Garantes> GetListaNombreGarantes(string aux)
        {
            List<Garantes> lista = new List<Garantes>();

            var db = new SistemaVentasDb();

            lista = db.Garantes.Where(p => p.Nombre == aux).ToList();

            return lista;

        }

        public static List<Garantes> GetListaApellido(string aux)
        {
            List<Garantes> lista = new List<Garantes>();

            var db = new SistemaVentasDb();

            lista = db.Garantes.Where(p => p.Apellido == aux).ToList();

            return lista;

        }

        public static List<Garantes> GetListaSexo(string aux)
        {
            List<Garantes> lista = new List<Garantes>();

            var db = new SistemaVentasDb();

            lista = db.Garantes.Where(p => p.Sexo == aux).ToList();

            return lista;

        }

        public static List<Garantes> GetListaCedula(string aux)
        {
            List<Garantes> lista = new List<Garantes>();

            var db = new SistemaVentasDb();

            lista = db.Garantes.Where(p => p.Cedula == aux).ToList();

            return lista;

        }
        public static List<Garantes> GetListaFecha(DateTime aux)
        {
            List<Garantes> lista = new List<Garantes>();

            var db = new SistemaVentasDb();

            lista = db.Garantes.Where(p => p.Fecha == aux).ToList();

            return lista;

        }
        public static List<Garantes> GetListaFecha(DateTime Desde, DateTime Hasta)
        {
            List<Garantes> lista = new List<Garantes>();

            var db = new SistemaVentasDb();

            lista = db.Garantes.Where(p => p.Fecha >= Desde && p.Fecha <= Hasta).ToList();

            return lista;

        }

    }
}
