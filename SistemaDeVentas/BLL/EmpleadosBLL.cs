using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;


namespace BLL
{
    public class EmpleadosBLL
    {
        Empleados empleados = new Empleados();

        public static bool Insertar(Empleados e)
        {
            //bool retorna = false;

            try
            {

                using (var db = new SistemaVentasDb())
                {

                    db.Empleados.Add(e);
                    db.SaveChanges();
                    db.Dispose();
                    //retorna = true;
                    return true;
                }


            }
            catch (Exception )
            {
                return false;
                throw;

            }
         // return   retorna;
        }


        public static Empleados Buscar(int id)
        {
            var db = new SistemaVentasDb();

            return db.Empleados.Find(id);


        }

        public static bool Eliminar(int id)
        {
            //bool retorna = false;
            try
            {

                using (var db = new SistemaVentasDb())
                {
                    Empleados e = new Empleados();
                    e = db.Empleados.Find(id);

                    db.Empleados.Remove(e);
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







        public static List<Empleados> GetLista()
        {
            List<Empleados> lista = new List<Empleados>();

            var db = new SistemaVentasDb();

            lista = db.Empleados.ToList();

            return lista;


        }

        public static List<Empleados> GetLista(int empleadoId)
        {
            List<Empleados> lista = new List<Empleados>();

            var db = new SistemaVentasDb();

            lista = db.Empleados.Where(p => p.EmpleadoId == empleadoId).ToList();

            return lista;

        }



        public static List<Empleados> GetListaNombreEmpleado(string aux)
        {
            List<Empleados> lista = new List<Empleados>();

            var db = new SistemaVentasDb();

            lista = db.Empleados.Where(p => p.Nombre == aux).ToList();

            return lista;

        }

        public static List<Empleados> GetListaApellido(string aux)
        {
            List<Empleados> lista = new List<Empleados>();

            var db = new SistemaVentasDb();

            lista = db.Empleados.Where(p => p.Apellido == aux).ToList();

            return lista;

        }

        public static List<Empleados> GetListaSexo(string aux)
        {
            List<Empleados> lista = new List<Empleados>();

            var db = new SistemaVentasDb();

            lista = db.Empleados.Where(p => p.Sexo == aux).ToList();

            return lista;

        }

        public static List<Empleados> GetListaFechaNacimiento(string aux)
        {
            List<Empleados> lista = new List<Empleados>();

            var db = new SistemaVentasDb();

            lista = db.Empleados.Where(p => p.FechaNacimiento== aux).ToList();

            return lista;

        }

        public static List<Empleados> GetListaCedula(string aux)
        {
            List<Empleados> lista = new List<Empleados>();

            var db = new SistemaVentasDb();

            lista = db.Empleados.Where(p => p.Cedula == aux).ToList();

            return lista;

        }
        public static List<Empleados> GetListaFechaIngreso(DateTime aux)
        {
            List<Empleados> lista = new List<Empleados>();

            var db = new SistemaVentasDb();

            lista = db.Empleados.Where(p => p.FechaIngreso== aux).ToList();

            return lista;

        }
        public static List<Empleados> GetListaFecha(DateTime Desde, DateTime Hasta)
        {
            List<Empleados> lista = new List<Empleados>();

            var db = new SistemaVentasDb();

            lista = db.Empleados.Where(p => p.FechaIngreso>= Desde && p.FechaIngreso <= Hasta).ToList();

            return lista;

        }
    }
}
