using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;

namespace BLL
{
   public class TiposUsuariosBLL
    {

        TipoUsuarios usuario = new TipoUsuarios();

        public static bool Insertar(TipoUsuarios u)
        {
            bool retorna = false;
            try
            {

                using (var db = new SistemaVentasDb())
                {

                    db.TipoUsuarios.Add(u);
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

        public static TipoUsuarios Buscar(int id)
        {
            var db = new SistemaVentasDb();

            return db.TipoUsuarios.Find(id);


        }

        public static void Eliminar(int id)
        {
            var db = new SistemaVentasDb();
            TipoUsuarios u= db.TipoUsuarios.Find(id);

            db.TipoUsuarios.Remove(u);
            db.SaveChanges();
        }

        public static List<TipoUsuarios> GetLista(string detalle)
        {
            List<TipoUsuarios> lista = new List<TipoUsuarios>();

            var db = new SistemaVentasDb();

            lista = db.TipoUsuarios.Where(p => p.Detalle == detalle).ToList();

            return lista;

        }
    }
}
