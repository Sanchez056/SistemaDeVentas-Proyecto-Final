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
    public class EmpleadosBLLTests
    {

        [TestMethod()]
        public void InsertarTest()
        {
            Empleados es = new Empleados();
            Assert.IsNotNull(EmpleadosBLL.Insertar(es));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNull(EmpleadosBLL.Buscar(1));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsTrue(UsuariosBLL.Eliminar(1));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsNotNull(EmpleadosBLL.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.IsNotNull(EmpleadosBLL.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaNombreEmpleadoTest()
        {
            Assert.IsNotNull(EmpleadosBLL.GetListaNombreEmpleado("JOSE").Count > 0);
        }

        [TestMethod()]
        public void GetListaApellidoTest()
        {
            Assert.IsNotNull(EmpleadosBLL.GetListaApellido("Molina").Count > 0);
        }

        [TestMethod()]
        public void GetListaSexoTest()
        {
            Assert.IsNotNull(EmpleadosBLL.GetListaSexo("M").Count > 0);
        }

        [TestMethod()]
        public void GetListaFechaNacimientoTest()
        {
            Assert.IsNotNull(EmpleadosBLL.GetListaFechaNacimiento("11/03/1994"));
        }

        [TestMethod()]
        public void GetListaCedulaTest()
        {
            Assert.IsNotNull(EmpleadosBLL.GetListaCedula("932323232").Count > 0);
        }

        [TestMethod()]
        public void GetListaFechaIngresoTest()
        {
            Assert.IsNotNull(EmpleadosBLL.GetListaFechaIngreso(DateTime.Today));
        }

        [TestMethod()]
        public void GetListaFechaTest()
        {
            Assert.IsNotNull(ArticuloBLL.GetListaFecha(DateTime.Today));
        }

        [TestMethod()]
        public void InsertarTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListaTest2()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListaTest3()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListaNombreEmpleadoTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListaApellidoTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListaSexoTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListaFechaNacimientoTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListaCedulaTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListaFechaIngresoTest1()
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
