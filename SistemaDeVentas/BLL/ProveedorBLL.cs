using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;


namespace BLL
{
   public class ProveedorBLL
    {
        Proveedores proveedores = new Proveedores();

        public static void Insertar(Proveedores p)
        {

            try
            {

                using (var db = new SistemaVentasDb())
                {

                    db.Proveedores.Add(p);
                    db.SaveChanges();
                    db.Dispose();

                }


            }
            catch (Exception e)
            {
                throw e;

            }

        }

        public static Proveedores Buscar(int id)
        {
            var db = new SistemaVentasDb();

            return db.Proveedores.Find(id);


        }

        public static void Eliminar(int id)
        {
            var db = new SistemaVentasDb();
            Proveedores p = db.Proveedores.Find(id);

            db.Proveedores.Remove(p);
            db.SaveChanges();
        }


        public static List<Proveedores> GetLista()
        {
            List<Proveedores> lista = new List<Proveedores>();

            var db = new SistemaVentasDb();

            lista = db.Proveedores.ToList();

            return lista;


        }

        public static List<Proveedores> GetLista(int proveedorId)
        {
            List<Proveedores> lista = new List<Proveedores>();

            var db = new SistemaVentasDb();

            lista = db.Proveedores.Where(p => p.ProveedorId == proveedorId).ToList();

            return lista;

        }



        public static List<Proveedores> GetListaNombreProveedor(string aux)
        {
            List<Proveedores> lista = new List<Proveedores>();

            var db = new SistemaVentasDb();

            lista = db.Proveedores.Where(p => p.NombreProveedor == aux).ToList();

            return lista;

        }

       

       
        public static List<Proveedores> GetListaFecha(DateTime aux)
        {
            List<Proveedores> lista = new List<Proveedores>();

            var db = new SistemaVentasDb();

            lista = db.Proveedores.Where(p => p.FechaIngreso == aux).ToList();

            return lista;

        }
        public static List<Proveedores> GetListaFecha(DateTime Desde, DateTime Hasta)
        {
            List<Proveedores> lista = new List<Proveedores>();

            var db = new SistemaVentasDb();

            lista = db.Proveedores.Where(p => p.FechaIngreso >= Desde && p.FechaIngreso <= Hasta).ToList();

            return lista;

        }



    }
}

