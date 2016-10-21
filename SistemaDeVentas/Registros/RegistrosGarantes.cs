using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace SistemaDeVentas.Registros
{
    public partial class RegistrosGarantes : Form
    {
        public RegistrosGarantes()
        {
            InitializeComponent();
        }

        private void RegistrosGarantes_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TelefonoRecidencialtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        Utilidades ut = new Utilidades();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del Garantes que desea buscar") && ValidarBuscar())
                LLenar(GaranteBLL.Buscar(ut.StringInt(GaranteIdtextBox.Text)));
        }

        private void LLenar(Garantes garante)
        {
            GaranteIdtextBox.Text = garante.GeranteId.ToString();
            NombretextBox.Text = garante.Nombre;
            ApellidotextBox.Text = garante.Apellido;
           // cedulaMaskedTextBox = garante.Celula;
            DirecciontextBox.Text = garante.Direccion;
            TelefonoRecidencialMaskedTextBox.Text = garante.Telefono;
            CeluarmaskedTextBox1.Text = garante.Celular;

        }
       
        private bool ValidarBuscar()
        {
            if (ClientesBLL.Buscar(ut.StringInt(GaranteIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(GaranteIdtextBox.Text))
            {

                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }


        private void NuevoBotton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            // DateTimePicker f = new DateTimePicker();
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            cedulaMaskedTextBox.Clear();
            DirecciontextBox.Clear();
            TelefonoRecidencialMaskedTextBox.Clear();
            CeluarmaskedTextBox1.Clear();
            // FechaIngresodateTimePicker1.Value = f.Value;

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Garantes garante = new Garantes();
            //BuscarerrorProvider.Clear();
            LlenarClase(garante);
            if (ValidarTextbox() && ValidarExiste(cedulaMaskedTextBox.Text))
            {
                GaranteBLL.Insertar(garante);
                Limpiar();
                MessageBox.Show("-_-Guardado Con Exito-_-");
            }

        }
        private bool ValidarExiste(string aux)
        {
            if (GaranteBLL.GetListaCedula(aux).Count() > 0)
            {
                MessageBox.Show("Este numero cedula  de Garante  ya existe, favor intentar con otro Garante ...");
                return false;
            }
            return true;
        }
        private void LlenarClase(Garantes g)
        {
            g.Nombre = NombretextBox.Text;
            g.Apellido = ApellidotextBox.Text;
            g.Celula= cedulaMaskedTextBox.Text;
            g.Direccion = DirecciontextBox.Text;
            g.Telefono = TelefonoRecidencialMaskedTextBox.Text;
            g.Celular = CeluarmaskedTextBox1.Text;


        }


        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(NombretextBox.Text) &&
                string.IsNullOrEmpty(ApellidotextBox.Text) &&
                string.IsNullOrEmpty(cedulaMaskedTextBox.Text) &&
                string.IsNullOrEmpty(DirecciontextBox.Text) &&
                string.IsNullOrEmpty(TelefonoRecidencialMaskedTextBox.Text) &&
                string.IsNullOrEmpty(CeluarmaskedTextBox1.Text)
               
                )
            {
                /* CodigoArticuloerrorProvider1.SetError(CodigoArticulotextBox, "Favor Ingresar un Codigo al Articulo");
                 NombreArticuloerrorProvider1.SetError(NombreArticulotextBox, "Favor Ingresar el Nombre al Articulo");
                 MarcaArticuloerrorProvider1.SetError(MarcaArticulotextBox, "Favor Ingresar la Marca del Articulo");
                 NombreProveedorerrorProvider1.SetError(NombreProveedortextBox, "Favor Ingresar el Proveedor del Articulo");
                 DescripcionerrorProvider1.SetError(DespcripciontextBox, "Favor Ingresar Descripcion Articulo");
                 CantidaderrorProvider1.SetError(CantidadArticulotextBox, "Favor Ingresar Cantidad de  Articulo");
                 PrecioCompraArticuloerrorProvider1.SetError(PrecioCompraArticulotextBox, "Favor Ingresar Precio de Compra de el Articulo");
                 PrecioVentasArticuloerrorProvider1.SetError(PrecioVentastextBox, "Favor Ingresar Precio para la Venta del  Articulo");
                 */
                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                //CodigoArticuloerrorProvider1.Clear();
                //CodigoArticuloerrorProvider1.SetError(CodigoArticulotextBox, "Favor ingresar el Codigo del Articulo");
                return false;
            }
            if (string.IsNullOrEmpty(ApellidotextBox.Text))
            {
                //NombreArticuloerrorProvider1.Clear();
                //NombreArticuloerrorProvider1.SetError(NombreArticulotextBox, "Favor ingresar el nombre del Articulo");
                return false;
            }

            if (string.IsNullOrEmpty(cedulaMaskedTextBox.Text))
            {
                //MarcaArticuloerrorProvider1.Clear();
                //MarcaArticuloerrorProvider1.SetError(MarcaArticulotextBox, "Favor ingresar la marca del Articulo");
                return false;
            }
            if (string.IsNullOrEmpty(DirecciontextBox.Text))
            {
                //NombreProveedorerrorProvider1.Clear();

                //NombreProveedorerrorProvider1.SetError(NombreProveedortextBox, "Favor ingrese el nombre del proveedor de el articulo");
                return false;
            }

            if (string.IsNullOrEmpty(TelefonoRecidencialMaskedTextBox.Text))
            {
                //DescripcionerrorProvider1.Clear();
                //DescripcionerrorProvider1.SetError(DespcripciontextBox, "Favor ingrese la descripcion del articulo");
                return false;
            }

            if (string.IsNullOrEmpty(CeluarmaskedTextBox1.Text))
            {
                //DescripcionerrorProvider1.Clear();
                //DescripcionerrorProvider1.SetError(DespcripciontextBox, "Favor ingrese la descripcion del articulo");
                return false;
            }


            return true;
        }


        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id del Garante que desea eliminar") && ValidarBuscar())
            {
                ClientesBLL.Eliminar(ut.StringInt(GaranteIdtextBox.Text));
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }
        }
    }
}
