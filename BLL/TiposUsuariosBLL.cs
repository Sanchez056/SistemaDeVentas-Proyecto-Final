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
        public static List<TipoUsuarios> GetLista(string detalle)
        {
            List<TipoUsuarios> lista = new List<TipoUsuarios>();

            var db = new SistemaVentasDb();

            lista = db.TipoUsuarios.Where(p => p.Detalle == detalle).ToList();

            return lista;

        }
    }
}
