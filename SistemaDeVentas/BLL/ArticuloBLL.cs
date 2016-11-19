﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using Entidades;
using SistemaDeVentas.Entidades;

namespace BLL
{
    public class ArticuloBLL
    {
        Articulos articulos= new Articulos();

        public static bool Insertar(Articulos a)
        {
            bool retorna = false;

            try
            {

                using (var db = new SistemaVentasDb())
                {

                    db.Articulos.Add(a);
                    db.SaveChanges();
                    db.Dispose();
                    retorna= true;

                }


            }
            catch (Exception)
            {
                throw;

            }
            return retorna;

        }

        public static Articulos Buscar(int id)
        {
            var db = new SistemaVentasDb();

            return db.Articulos.Find(id);


        }

       

        public static bool Eliminar(int id)
        {
            //bool retorna = false;
            try
            {

                using (var db = new SistemaVentasDb())
                {
                    Articulos a = new Articulos();
                    a = db.Articulos.Find(id);

                    db.Articulos.Remove(a);
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

    


        public static List<Articulos> GetLista()
        {
            List<Articulos> lista = new List<Articulos>();

            var db = new SistemaVentasDb();

            lista = db.Articulos.ToList();

            return lista;


        }

        public static List<Articulos> GetLista(int articuloId)
        {
            List<Articulos> lista = new List<Articulos>();

            var db = new SistemaVentasDb();

            lista = db.Articulos.Where(p => p.ArticuloId == articuloId).ToList();

            return lista;

        }



        public static List<Articulos> GetListaNombreArticulo(string aux)
        {
            List<Articulos> lista = new List<Articulos>();

            var db = new SistemaVentasDb();

            lista = db.Articulos.Where(p => p.Nombre== aux).ToList();

            return lista;

        }
        public static List<Articulos> GetListaMarcaArticulo(string aux)
        {
            List<Articulos> lista = new List<Articulos>();

            var db = new SistemaVentasDb();

            lista = db.Articulos.Where(p => p.Marca== aux).ToList();

            return lista;

        }

        public static List<Articulos> GetListaCodigoArticulo(string aux)
        {
            List<Articulos> lista = new List<Articulos>();

            var db = new SistemaVentasDb();

            lista = db.Articulos.Where(p => p.Codigo== aux).ToList();

            return lista;

        }

        
      
       public static List<Articulos> GetListaFecha(DateTime aux)
        {
            List<Articulos> lista = new List<Articulos>();

            var db = new SistemaVentasDb();

            lista = db.Articulos.Where(p => p.Fecha== aux).ToList();

            return lista;

        }
       public static List<Articulos> GetListaFecha(DateTime Desde, DateTime Hasta)
        {
            List<Articulos> lista = new List<Articulos>();

            var db = new SistemaVentasDb();

            lista = db.Articulos.Where(p => p.Fecha >= Desde && p.Fecha <= Hasta).ToList();

            return lista;

        }
        
    }
}
