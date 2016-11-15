using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;
using Entidades;

namespace BLL
{
    public class UsuariosBLL 
    {

        Usuarios usuario = new Usuarios();

        public static  bool Insertar(Usuarios u)
        {
            bool retorna = false;
              try
               {

                using (var db = new SistemaVentasDb())
                {

                    db.Usuarios.Add(u);
                    db.SaveChanges();
                    //db.Dispose();
                    retorna = true;
                }


            }
            catch (Exception)
            {
                throw;

            }
            return retorna;

        }

        public static Usuarios Buscar(int id)
        {
            var db = new SistemaVentasDb();

            return db.Usuarios.Find(id);


        }

        public static void Eliminar(int id)
        {
            var db = new SistemaVentasDb();
            Usuarios u = db.Usuarios.Find(id);

            db.Usuarios.Remove(u);
            db.SaveChanges();
        }





        public static List<Usuarios> GetListaNombreUsuario(string aux)
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new SistemaVentasDb();

            lista = db.Usuarios.Where(p => p.NombreUsuario == aux).ToList();

            return lista;

        }
       
        public static List<Usuarios> GetListaIdUsuarios(int id)
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new SistemaVentasDb();

            lista = db.Usuarios.Where(p => p.UsuarioId == id).ToList();

            return lista;

        }

        public static List<Usuarios> GetLista()
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new SistemaVentasDb();

            lista = db.Usuarios.ToList();

            return lista;


        }
        public static List<Usuarios> GetLista(int usuarioId)
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new SistemaVentasDb();

            lista = db.Usuarios.Where(p => p.UsuarioId == usuarioId).ToList();

            return lista;

        }
        public static List<Usuarios> CargarDatos()
        {
            using (SistemaVentasDb db = new SistemaVentasDb())
            {
                var datos = (from p in db.Usuarios select p).ToList();

                return datos;
            }
        }
        public static List<Usuarios> getContraseña(string aux)
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new SistemaVentasDb();

            lista = db.Usuarios.Where(p => p.Contrasena== aux).ToList();

            return lista;

        }
    }
}

