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
    public partial class RegistrosArticulo : Form
    {
        Utilidades ut = new Utilidades();
        public RegistrosArticulo()
        {
            InitializeComponent();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id del articulo que desea eliminar") && ValidarBuscar())
            {
                ArticuloBLL.Eliminar(ut.StringInt(ArticuloIdtextBox.Text));
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
         
            if (validarId("Favor ingresar el id del articulo que desea buscar") && ValidarBuscar())
                LLenar(ArticuloBLL.Buscar(ut.StringInt(ArticuloIdtextBox.Text)));

        }
        private void LLenar(Articulos articulo)
        {
            ArticuloIdtextBox.Text = articulo.ArticuloId.ToString();
            CodigoArticulotextBox.Text = articulo.CodigoArticulo;
            NombreArticulotextBox.Text = articulo.NombreArticulo;
            MarcaArticulotextBox.Text = articulo.MarcaArticulo;
            NombreProveedortextBox.Text = articulo.NombreProveedor;
            DespcripciontextBox.Text = articulo.Despcricion;
            PrecioCompraArticulotextBox.Text = articulo.PrecioCompraArticulo.ToString();
            PrecioVentastextBox.Text = articulo.PrecioVentaArticulo.ToString();
            CantidadArticulotextBox.Text = articulo.CantidadArticulo.ToString();
           
            

        }
        private bool ValidarBuscar()
        {
            if (ArticuloBLL.Buscar(ut.StringInt(ArticuloIdtextBox.Text)) == null)
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
        
        
        //-----


        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
           // DateTimePicker f = new DateTimePicker();
            ArticuloIdtextBox.Clear();
            CodigoArticulotextBox.Clear();
            NombreArticulotextBox.Clear();
            MarcaArticulotextBox.Clear();
            NombreProveedortextBox.Clear();
            DespcripciontextBox.Clear();
            CantidadArticulotextBox.Clear();
            PrecioCompraArticulotextBox.Clear();
            PrecioVentastextBox.Clear();
           // FechaIngresodateTimePicker1.Value = f.Value;
            
        }


        //----
        private void Guardabutton_Click(object sender, EventArgs e)
        {

             Articulos articulo = new Articulos();
             BuscarerrorProvider.Clear();
            LlenarClase(articulo);
            if (ValidarTextbox() && ValidarExiste(CodigoArticulotextBox.Text))
            {
                ArticuloBLL.Insertar(articulo);
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
        private void LlenarClase(Articulos a)
        {
            a.CodigoArticulo = CodigoArticulotextBox.Text;
            a.NombreArticulo = NombreArticulotextBox.Text;
            a.MarcaArticulo = MarcaArticulotextBox.Text;
            a.NombreProveedor = NombreProveedortextBox.Text;
            a.Despcricion = DespcripciontextBox.Text;
            a.CantidadArticulo = int.Parse(CantidadArticulotextBox.Text);
            a.PrecioCompraArticulo= int.Parse(PrecioCompraArticulotextBox.Text);
            a.PrecioVentaArticulo = int.Parse(PrecioVentastextBox.Text);
           // a.FechaIngreso = DateTime.Parse(FechaIngresodateTimePicker1.Text);
               

        }
       
       
        private bool ValidarTextbox()
        {
            
            if (string.IsNullOrEmpty(CodigoArticulotextBox.Text) && 
                string.IsNullOrEmpty(NombreArticulotextBox.Text) && 
                string.IsNullOrEmpty(MarcaArticulotextBox.Text) &&
                string.IsNullOrEmpty(NombreProveedortextBox.Text) &&
                string.IsNullOrEmpty(DespcripciontextBox.Text) && 
                string.IsNullOrEmpty(CantidadArticulotextBox.Text) && 
                string.IsNullOrEmpty(PrecioCompraArticulotextBox.Text)&& 
                string.IsNullOrEmpty(PrecioVentastextBox.Text)
                )
            {
                CodigoArticuloerrorProvider1.SetError(CodigoArticulotextBox, "Favor Ingresar un Codigo al Articulo");
                NombreArticuloerrorProvider1.SetError(NombreArticulotextBox, "Favor Ingresar el Nombre al Articulo");
                MarcaArticuloerrorProvider1.SetError(MarcaArticulotextBox, "Favor Ingresar la Marca del Articulo");
                NombreProveedorerrorProvider1.SetError(NombreProveedortextBox, "Favor Ingresar el Proveedor del Articulo");
                DescripcionerrorProvider1.SetError(DespcripciontextBox, "Favor Ingresar Descripcion Articulo");
                CantidaderrorProvider1.SetError(CantidadArticulotextBox, "Favor Ingresar Cantidad de  Articulo");
                PrecioCompraArticuloerrorProvider1.SetError(PrecioCompraArticulotextBox, "Favor Ingresar Precio de Compra de el Articulo");
                PrecioVentasArticuloerrorProvider1.SetError(PrecioVentastextBox, "Favor Ingresar Precio para la Venta del  Articulo");

                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(CodigoArticulotextBox.Text))
            {
                CodigoArticuloerrorProvider1.Clear();
                CodigoArticuloerrorProvider1.SetError(CodigoArticulotextBox, "Favor ingresar el Codigo del Articulo");
                return false;
            }
            if (string.IsNullOrEmpty(NombreArticulotextBox.Text))
            {
                NombreArticuloerrorProvider1.Clear();
                NombreArticuloerrorProvider1.SetError(NombreArticulotextBox, "Favor ingresar el nombre del Articulo");
                return false;
            }

            if (string.IsNullOrEmpty(MarcaArticulotextBox.Text))
            {
                MarcaArticuloerrorProvider1.Clear();
                MarcaArticuloerrorProvider1.SetError(MarcaArticulotextBox, "Favor ingresar la marca del Articulo");
                return false;
            }
            if (string.IsNullOrEmpty(NombreProveedortextBox.Text))
            {
                NombreProveedorerrorProvider1.Clear();
               
                NombreProveedorerrorProvider1.SetError(NombreProveedortextBox, "Favor ingrese el nombre del proveedor de el articulo");
                return false;
            }

            if (string.IsNullOrEmpty(DespcripciontextBox.Text))
            {
               DescripcionerrorProvider1.Clear();               
               DescripcionerrorProvider1.SetError(DespcripciontextBox, "Favor ingrese la descripcion del articulo");
                return false;
            }
            if (string.IsNullOrEmpty(CantidadArticulotextBox.Text))
            {
                 CantidaderrorProvider1.Clear();
                 CantidaderrorProvider1.SetError(CantidadArticulotextBox, "Favor ingrese la cantidad del articulo");
                return false;
            }
            if (string.IsNullOrEmpty(PrecioCompraArticulotextBox.Text))
            {
                 PrecioCompraArticuloerrorProvider1.Clear();
                 PrecioCompraArticuloerrorProvider1.SetError(PrecioCompraArticulotextBox, "Favor Ingrese el precio de compra");
                return false;
            }
            if (string.IsNullOrEmpty(PrecioVentastextBox.Text))
            {
                 PrecioVentasArticuloerrorProvider1.Clear();
                 PrecioVentasArticuloerrorProvider1.SetError(PrecioVentastextBox, "Favor ingrese el precio en se vendera el articulo");
                return false;
            }
            

            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrosArticulo_Load(object sender, EventArgs e)
        {

        }
    }
}
