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
    public partial class RegistroDeProveedores : Form
    {
        public RegistroDeProveedores()
        {
            InitializeComponent();
        }

        Utilidades ut = new Utilidades();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del Proveedor que desea buscar") && ValidarBuscar())
                LLenar(ProveedorBLL.Buscar(ut.StringInt(ProveedorIdtextBox.Text)));
        }
        private void LLenar(Proveedores proveedor)
        {
            ProveedorIdtextBox.Text = proveedor.ProveedorId.ToString();
            NombretextBox.Text = proveedor.NombreCompañia;
            DirreciontextBox.Text = proveedor.Direccion;
            CiudadtextBox.Text = proveedor.Ciudad;
            TelefonomaskedTextBox.Text = proveedor.Telefono;
            FaxmaskedTextBox.Text = proveedor.Fax;
            CorreotextBox.Text = proveedor.Correo;
  
        }

        private bool ValidarBuscar()
        {
            if (ClientesBLL.Buscar(ut.StringInt(ProveedorIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(ProveedorIdtextBox.Text))
            {

                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            // DateTimePicker f = new DateTimePicker();
            NombretextBox.Clear();
            DirreciontextBox.Clear();
            CiudadtextBox.Clear();
            TelefonomaskedTextBox.Clear();
            FaxmaskedTextBox.Clear();
            CorreotextBox.Clear();
            // FechaIngresodateTimePicker1.Value = f.Value;

        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Proveedores proveedor = new Proveedores();
            //BuscarerrorProvider.Clear();
            LlenarClase(proveedor);
            if (ValidarTextbox() && ValidarExiste(NombretextBox.Text))
            {
                ProveedorBLL.Insertar(proveedor);
                Limpiar();
                MessageBox.Show("-_-Guardado Con Exito-_-");
            }

        }

        private bool ValidarExiste(string aux)
        {
            if (ProveedorBLL.GetListaNombreProveedro(aux).Count() > 0)
            {
                MessageBox.Show("Este Nombre proveedor de ya existe, favor intentar con otro Nombre de Proveedor...");
                return false;
            }
            return true;
        }

        private void LlenarClase(Proveedores p)
        {
            p.NombreCompañia = NombretextBox.Text;
            p.Direccion = DirreciontextBox.Text;
            p.Ciudad = CiudadtextBox.Text;
            p.Telefono= TelefonomaskedTextBox.Text;
            p.Fax = FaxmaskedTextBox.Text;
            p.Correo = CorreotextBox.Text;


        }
        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(NombretextBox.Text) &&
                string.IsNullOrEmpty(DirreciontextBox.Text) &&
                string.IsNullOrEmpty(CiudadtextBox.Text) &&
                string.IsNullOrEmpty(TelefonomaskedTextBox.Text) &&
                string.IsNullOrEmpty(FaxmaskedTextBox.Text) &&
                string.IsNullOrEmpty(CorreotextBox.Text) 
                
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
            if (string.IsNullOrEmpty(DirreciontextBox.Text))
            {
                //NombreArticuloerrorProvider1.Clear();
                //NombreArticuloerrorProvider1.SetError(NombreArticulotextBox, "Favor ingresar el nombre del Articulo");
                return false;
            }

            if (string.IsNullOrEmpty(CiudadtextBox.Text))
            {
                //MarcaArticuloerrorProvider1.Clear();
                //MarcaArticuloerrorProvider1.SetError(MarcaArticulotextBox, "Favor ingresar la marca del Articulo");
                return false;
            }
            if (string.IsNullOrEmpty(TelefonomaskedTextBox.Text))
            {
                //NombreProveedorerrorProvider1.Clear();

                //NombreProveedorerrorProvider1.SetError(NombreProveedortextBox, "Favor ingrese el nombre del proveedor de el articulo");
                return false;
            }

            if (string.IsNullOrEmpty(FaxmaskedTextBox.Text))
            {
                //DescripcionerrorProvider1.Clear();
                //DescripcionerrorProvider1.SetError(DespcripciontextBox, "Favor ingrese la descripcion del articulo");
                return false;
            }
            if (string.IsNullOrEmpty(CorreotextBox.Text))
            {
                //DescripcionerrorProvider1.Clear();
                //DescripcionerrorProvider1.SetError(DespcripciontextBox, "Favor ingrese la descripcion del articulo");
                return false;
            }


            return true;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id del Proveedor que desea eliminar") && ValidarBuscar())
            {
                ProveedorBLL.Eliminar(ut.StringInt(ProveedorIdtextBox.Text));
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }
        }
    }
}

