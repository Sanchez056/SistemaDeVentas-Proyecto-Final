using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace BLL
{
    public class CiudadClientesBLL
    {
        public static List<CiudadClientes> GetLista(string ciudad)
        {
            List<CiudadClientes> lista = new List<CiudadClientes>();

            var db = new SistemaVentasDb ();

            lista = db.CiudadCliente.Where(p => p.CiudadCliente== ciudad).ToList();

            return lista;

        }
    }
}
