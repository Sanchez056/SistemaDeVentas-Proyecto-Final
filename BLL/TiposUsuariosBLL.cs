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
        public static List<TiposUsuarios> GetLista()
        {
            List<TiposUsuarios> lista = new List<TiposUsuarios>();

            var db = new SistemaVentasDb();

            lista = db.TipoUsuario.ToList();

            return lista;

        }
    }
}
