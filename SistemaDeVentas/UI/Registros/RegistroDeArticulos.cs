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
using DAL;

namespace SistemaDeVentas.UI.Registros
{
    public partial class RegistroDeArticulos : Form
    {
        Entidades.Articulos articulos = new Entidades.Articulos();
         public RegistroDeArticulos()
        {
            InitializeComponent();
        }

        public double StringDouble(string texto)
        {
            double numero = 0;

            double.TryParse(texto, out numero);

            return numero;
        }
        public void CargarCombox()
        {

        }

        private void NombreProveedorcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            DateTimePicker f = new DateTimePicker();
            ArticuloIdtextBox.Clear();
            NombreArticulotextBox.Clear();
            MarcaArticulotextBox.Clear();
            DescuentotextBox.Clear();
            DespcripciontextBox.Clear();
            CantidadtextBox.Clear();
            PrecioCompratextBox.Clear();
            PrecioVentatextBox.Clear();
            NombreProveedorcomboBox1.Text = "Elegir una opcion";
            FechadateTimePicker.Value = f.Value;
            //-----
            limpiarErroresProvider();

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del Cliente que desea buscar") && ValidarBuscar())
                LLenar(ArticuloBLL.Buscar(ut.StringInt(ArticuloIdtextBox.Text)));
        }
        private void LLenar(Entidades.Articulos articulo)
        {

            ArticuloIdtextBox.Text = articulo.ArticuloId.ToString();
            NombreArticulotextBox.Text = articulo.Nombre;
            CodigoArticulotextBox.Text = articulo.Codigo;
            DespcripciontextBox.Text = articulo.Descripcion;
            CantidadtextBox.Text = articulo.Cantidad.ToString();
            PrecioCompratextBox.Text = articulo.PrecioCompra.ToString();
            PrecioVentatextBox.Text = articulo.PrecioVentas.ToString();
            MarcaArticulotextBox.Text = articulo.Marca;

           CargarConboBox();
        }
        private void Guardabutton_Click(object sender, EventArgs e)
        {

           Entidades.Articulos arti = new Entidades.Articulos();
            //BuscarerrorProvider1.Clear();
            LlenarClase(arti);
            CargarConboBox();
            if (ValidarTextbox() && ValidarExiste(CodigoArticulotextBox.Text))
            {
                ArticuloBLL.Insertar(arti);
                Limpiar();
                MessageBox.Show("Guardado con exito");
            }



        }
        Utilidades ut = new Utilidades();
        private bool ValidarBuscar()
        {
            if (ClientesBLL.Buscar(ut.StringInt(ArticuloIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(ArticuloIdtextBox.Text))
            {

                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidarExiste(string aux)
        {
            if (ArticuloBLL.GetListaCodigoArticulo(aux).Count() > 0)
            {
                MessageBox.Show("Este codigo ya existe, favor intentar con otra Codigo ...");
                return false;
            }
            return true;
        }
        private void LlenarClase(Entidades.Articulos a)
        {
            Proveedores p = new Proveedores();
            a.Codigo = CodigoArticulotextBox.Text;
            a.Nombre = NombreArticulotextBox.Text;
            a.Cantidad = ut.StringInt(CantidadtextBox.Text);
            a.Descripcion = DespcripciontextBox.Text; ;
            a.Marca = MarcaArticulotextBox.Text;
            a.PrecioCompra =StringDouble(PrecioCompratextBox.Text);
            a.PrecioVentas = StringDouble(PrecioVentatextBox.Text);
            a.Descuento = ut.StringInt(DescuentotextBox.Text);
            p.NombreProveedor = a.NombreProveedor = NombreProveedorcomboBox1.Text;
            a.Fecha = FechadateTimePicker.Value;
           

        }


        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(CodigoArticulotextBox.Text) &&
                string.IsNullOrEmpty(NombreArticulotextBox.Text) &&
                 string.IsNullOrEmpty(DespcripciontextBox.Text) &&
                 string.IsNullOrEmpty(CantidadtextBox.Text) &&
                string.IsNullOrEmpty(MarcaArticulotextBox.Text) &&
                string.IsNullOrEmpty(PrecioCompratextBox.Text) &&
                string.IsNullOrEmpty(PrecioVentatextBox.Text)
               


                )
            {
               // NombreerrorProvider2.SetError(CodigoArticulotextBox, "Favor Ingresar el codigo de articulo");
               // ApellidoerrorProvider3.SetError(NombreArticulotextBox, "Favor Ingresar el  nombre del articulos");
               // CedulaerrorProvider4.SetError(MarcaArticulotextBox, "Favor Ingresar la marca del articulo");
               // DirrecionerrorProvider8.SetError(DespcripciontextBox, "Favor Ingresar la descripcion del articulo");
               // TelefonoerrorProvider9.SetError(CantidadtextBox, "Favor Ingresar la cantidad de articulo");
               // TelefonoerrorProvider9.SetError(PrecioCompratextBox, "Favor Ingresar el precio de compra de articulo");
               // CedulaerrorProvider4.SetError(PrecioVentatextBox, "Favor Ingresarel el precio de venta del articulo");

                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(CodigoArticulotextBox.Text))
            {
               // NombreerrorProvider2.Clear();
                //NombreerrorProvider2.SetError(CodigoArticulotextBox, "Favor ingresar el Nombre de codigo del articulo");
                return false;
            }
            if (string.IsNullOrEmpty(NombreArticulotextBox.Text))
            {
                //ApellidoerrorProvider3.Clear();
               // ApellidoerrorProvider3.SetError(NombreArticulotextBox, "Favor ingresar el nombre del articulo");
                return false;
            }

            if (string.IsNullOrEmpty(DespcripciontextBox.Text))
            {
               // CedulaerrorProvider4.Clear();
               // CedulaerrorProvider4.SetError(DespcripciontextBox, "Favor ingresar la descripcion del articulos");
                return false;
            }
            if (string.IsNullOrEmpty(CantidadtextBox.Text))
            {
               // CiudaderrorProvider7.Clear();
               // CiudaderrorProvider7.SetError(CantidadtextBox, "Favor ingrese la cantidad del articulo");
                return false;
            }
            if (string.IsNullOrEmpty(DescuentotextBox.Text))
            {
                //DirecciontextBox.Clear();
                //DirrecionerrorProvider8.SetError(DescuentotextBox, "Favor ingrese la descuentos);
                return false;
            }

            if (string.IsNullOrEmpty(PrecioCompratextBox.Text))
            {
                //TelefonoerrorProvider9.Clear();
               // TelefonoerrorProvider9.SetError(PrecioCompratextBox, "Favor ingrese el precio compra");
                return false;
            }
            if (string.IsNullOrEmpty(PrecioVentatextBox.Text))
            {
               // CelularerrorProvider10.Clear();
               // CelularerrorProvider10.SetError(PrecioVentatextBox, "Favor ingrese el  precio de la venta del articulo");
                return false;
            }
            if (string.IsNullOrEmpty(MarcaArticulotextBox.Text))
            {
                //CelularerrorProvider10.Clear();
                // CelularerrorProvider10.SetError(MarcaArticulotextBox, "Favor ingrese el  precio de la venta del articulo");
                return false;
            }



            return true;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id del Articulo que desea eliminar") && ValidarBuscar())
            {
                ArticuloBLL.Eliminar(ut.StringInt(ArticuloIdtextBox.Text));
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }
        }
        public List<Proveedores> lista = new List<Proveedores>();
        private void CargarConboBox()
        {
            var db = new SistemaVentasDb();
            lista = db.Proveedores.ToList();
            if (lista.Count > 0)
            {
                NombreProveedorcomboBox1.DataSource = lista;
                NombreProveedorcomboBox1.ValueMember = "ProveedorId";
                NombreProveedorcomboBox1.DisplayMember = "NombreProveedor";
            }
        }
        ///---------------
        private void limpiarErroresProvider()
        {
            

        }

        private void Articulopanel_Paint(object sender, PaintEventArgs e)
        {
       
        }

        private void RegistroDeArticulos_Load(object sender, EventArgs e)
        {
             CargarConboBox();
        }
    }
}
