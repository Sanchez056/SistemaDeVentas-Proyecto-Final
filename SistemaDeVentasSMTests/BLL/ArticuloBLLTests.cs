using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeVentas.Entidades;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class ArticuloBLLTests
    {
       Articulos a = new Articulos();
        [TestMethod()]
        public void InsertarTest()
        {
            Assert.IsTrue(ArticuloBLL.Insertar(a));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNull(ArticuloBLL.Buscar(1));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsTrue(ArticuloBLL.Eliminar(1));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsNotNull(ArticuloBLL.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.IsTrue(ArticuloBLL.GetLista(1).Count > 0);
        }

        [TestMethod()]
        public void GetListaNombreArticuloTest()
        {
            Assert.IsNotNull(ArticuloBLL.GetListaNombreArticulo("cilindro").Count > 0);
        }
    

    [TestMethod()]
    public void GetListaMarcaArticuloTest()
    {
        Assert.IsNotNull(ArticuloBLL.GetListaMarcaArticulo("honda").Count > 0);

    } 

        [TestMethod()]
        public void GetListaCodigoArticuloTest()
        {
            Assert.IsNotNull(ArticuloBLL.GetListaCodigoArticulo("3232323").Count > 0);
       }
    

       

        [TestMethod()]
        public void GetListaFechaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListaFechaTest1()
        {
            Assert.Fail();
        }
    }
}