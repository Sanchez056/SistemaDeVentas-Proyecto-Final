using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;
using BLL;

namespace BLL
{
    public class ArticuloBLL
    {
        Articulos articulos= new Articulos();

        public static void Insertar(Articulos a)
        {

            try
            {

                using (var db = new SistemaVentasDb())
                {

                    db.Articulos.Add(a);
                    db.SaveChanges();
                    db.Dispose();

                }


            }
            catch (Exception e)
            {
                throw e;

            }

        }
    }
}
