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


namespace SistemaDeVentas
{
    public partial class RegistroDeClientes : Form
    {
        public RegistroDeClientes()
        {
            InitializeComponent();
        }

        private void Sexolabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistroDeClientes_Load(object sender, EventArgs e)
        {

        }
        private void LLenar(Clientes cliente)
        {
            ClienteIdtextBox.Text = cliente.ClienteId.ToString();
            NombretextBox.Text = cliente.Nombre;
            ApellidotextBox.Text = cliente.Apellido;
           // CedulamaskedTextBox4 = cliente.Cedula;
            DirecciontextBox.Text = cliente.Direccion;
            TelefonomaskedTextBox1.Text = cliente.Telefono;
            CelularmaskedTextBox2.Text = cliente.Celular;
            




        }
        Utilidades ut = new Utilidades();
        private bool ValidarBuscar()
        {
            if (ClientesBLL.Buscar(ut.StringInt(ClienteIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(ClienteIdtextBox.Text))
            {

                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }

        //----------
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            //BuscarerrorProvider.Clear();
            LlenarClase(cliente);
            if (ValidarTextbox() && ValidarExiste(CedulamaskedTextBox4.Text))
            {
                ClientesBLL.Insertar(cliente);
                Limpiar();
                MessageBox.Show("-_-Guardado Con Exito-_-");
            }


        }

        private bool ValidarExiste(string aux)
        {
            if (ArticuloBLL.GetListaCodigoArticulo(aux).Count() > 0)
            {
                MessageBox.Show("Este Codigo de Articulo ya existe, favor intentar con otro Codigo de Articulo...");
                return false;
            }
            return true;
        }
        private void LlenarClase(Clientes c)
        {
            c.Nombre = NombretextBox.Text;
            c.Apellido = ApellidotextBox.Text;
            c.Cedula = CedulamaskedTextBox4.Text;


        }


        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(NombretextBox.Text) &&
                string.IsNullOrEmpty(ApellidotextBox.Text) &&
                string.IsNullOrEmpty(CedulamaskedTextBox4.Text) &&
                string.IsNullOrEmpty(DirecciontextBox.Text) &&
                string.IsNullOrEmpty(TelefonomaskedTextBox1.Text) &&
                string.IsNullOrEmpty(CedulamaskedTextBox4.Text) &&
                string.IsNullOrEmpty(FechaIngresomaskedTextBox3.Text) 
                
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

            if (string.IsNullOrEmpty(CedulamaskedTextBox4.Text))
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

            if (string.IsNullOrEmpty(CelularmaskedTextBox2.Text))
            {
                //DescripcionerrorProvider1.Clear();
                //DescripcionerrorProvider1.SetError(DespcripciontextBox, "Favor ingrese la descripcion del articulo");
                return false;
            }
           


            return true;
        }




        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del Cliente que desea buscar") && ValidarBuscar())
                LLenar(ClientesBLL.Buscar(ut.StringInt(ClienteIdtextBox.Text)));
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            // DateTimePicker f = new DateTimePicker();
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            CedulamaskedTextBox4.Clear();
            DirecciontextBox.Clear();
            TelefonomaskedTextBox1.Clear();
            CelularmaskedTextBox2.Clear();
            // FechaIngresodateTimePicker1.Value = f.Value;

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id del Cliente que desea eliminar") && ValidarBuscar())
            {
                ClientesBLL.Eliminar(ut.StringInt(ClienteIdtextBox.Text));
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }
        }
    }
}
