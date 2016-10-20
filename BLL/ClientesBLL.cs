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
   public  class ClientesBLL
    {
        Clientes cliente= new Clientes();

        public static void Insertar(Clientes c)
        {

            try
            {

                using (var db = new SistemaVentasDb())
                {

                    db.Clientes.Add(c);
                    db.SaveChanges();
                    db.Dispose();

                }


            }
            catch (Exception e)
            {
                throw e;

            }

        }

        public static Clientes Buscar(int id)
        {
            var db = new SistemaVentasDb();

            return db.Clientes.Find(id);


        }

        public static void Eliminar(int id)
        {
            var db = new SistemaVentasDb();
            Clientes c = db.Clientes.Find(id);

            db.Clientes.Remove(c);
            db.SaveChanges();
        }


        public static List<Clientes> GetLista()
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new SistemaVentasDb();

            lista = db.Clientes.ToList();

            return lista;


        }

        public static List<Clientes> GetLista(int clienteId)
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new SistemaVentasDb();

            lista = db.Clientes.Where(p => p.ClienteId == clienteId).ToList();

            return lista;

        }



        public static List<Clientes> GetListaNombreCliente(string aux)
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new SistemaVentasDb();

            lista = db.Clientes.Where(p => p.Nombre == aux).ToList();

            return lista;

        }

        public static List<Clientes> GetListaApellido(string aux)
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new SistemaVentasDb();

            lista = db.Clientes.Where(p => p.Apellido== aux).ToList();

            return lista;

        }

        public static List<Clientes> GetListaCedula(string aux)
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new SistemaVentasDb();

            lista = db.Clientes.Where(p => p.Cedula == aux).ToList();

            return lista;

        }
    }
}
