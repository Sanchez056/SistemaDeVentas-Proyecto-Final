using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class UsuariosBLLTests
    {
        Usuarios us = new Usuarios();
        [TestMethod()]
        public void InsertarTest()
        {
           
            Assert.IsTrue(UsuariosBLL.Insertar(us));
        }

        [TestMethod()]
        public void BuscarTest()
        {

        }

        [TestMethod()]
        public void EliminarTest()
        {

        }

        [TestMethod()]
        public void GetListaNombreUsuarioTest()
        {

        }

        [TestMethod()]
        public void GetListaIdUsuariosTest()
        {
           
        }

        [TestMethod()]
        public void GetListaTest()
        {
           
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.IsTrue(UsuariosBLL.GetLista().Count > 0);
        }

        [TestMethod()]
        public void CargarDatosTest()
        {

        }

        [TestMethod()]
        public void getContraseñaTest()
        {

        }
    }
}