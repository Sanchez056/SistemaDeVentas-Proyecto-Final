using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
using SistemaDeVentas.Entidades;

namespace SistemaDeVentas.BLL
{
   public  class VentasBLL
    {
       
            Ventas  ventas = new Ventas();

            public static bool Insertar(Ventas v)
            {
                //  bool retorna = false;

                try
                {

                    using (var db = new SistemaVentasDb())
                    {

                        db.Ventas.Add(v);
                        db.SaveChanges();
                        db.Dispose();
                        // retorna= true;
                        return true;

                    }


                }
                catch (Exception)
                {
                    return false;
                    throw;

                }

                // return retorna;

            }

            public static Ventas Buscar(int id)
            {
                var db = new SistemaVentasDb();

                return db.Ventas.Find(id);


            }



            public static bool Eliminar(int id)
            {
                //bool retorna = false;
                try
                {

                    using (var db = new SistemaVentasDb())
                    {
                    Ventas v = new Ventas();
                       v = db.Ventas.Find(id);

                        db.Ventas.Remove(v);
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




            public static List<Ventas> GetLista()
            {
                List<Ventas> lista = new List<Ventas>();

                var db = new SistemaVentasDb();

                lista = db.Ventas.ToList();

                return lista;


            }

            

            public static List<Ventas> GetLista(int id)
            {
                List<Ventas> lista = new List<Ventas>();

                var db = new SistemaVentasDb();

                lista = db.Ventas.Where(p => p.VentaId== id).ToList();

                return lista;

            }



            public static List<Ventas> GetListaCodigo(string aux)
            {
                List<Ventas> lista = new List<Ventas>();

                var db = new SistemaVentasDb();

                lista = db.Ventas.Where(p => p.Codigo == aux).ToList();

                return lista;

            }
           

           


            public static List<Ventas> GetListaFecha(DateTime aux)
            {
                List<Ventas> lista = new List<Ventas>();

                var db = new SistemaVentasDb();

                lista = db.Ventas.Where(p => p.Fecha == aux).ToList();

                return lista;

            }
            public static List<Ventas> GetListaFecha(DateTime Desde, DateTime Hasta)
            {
                List<Ventas> lista = new List<Ventas>();

                var db = new SistemaVentasDb();

                lista = db.Ventas.Where(p => p.Fecha >= Desde && p.Fecha <= Hasta).ToList();

                return lista;

            }

        }
    }

