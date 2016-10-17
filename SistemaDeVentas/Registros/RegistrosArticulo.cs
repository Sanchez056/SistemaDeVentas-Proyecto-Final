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
            if (validarId("Favor digitar el id del usuario que desea eliminar") && ValidarBuscar())
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
            DespcripciontextBox.Text = articulo.Despcricion;
            PrecioArticulotextBox.Text = articulo.PrecioArticulo.ToString();
            CantidadArticulotextBox.Text = articulo.CantidadArticulo.ToString();
           
            //TipoUsuarioscomboBox.Text = usuario.TipoUsuarios;

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
            ArticuloIdtextBox.Clear();
            CodigoArticulotextBox.Clear();
            NombreArticulotextBox.Clear();
            MarcaArticulotextBox.Clear();
            DespcripciontextBox.Clear();
            CantidadArticulotextBox.Clear();
            PrecioArticulotextBox.Clear();
            ImagenArticulopictureBox.CancelAsync();
        }


        //----
        private void Guardabutton_Click(object sender, EventArgs e)
        {

             Articulos articulo = new Articulos();
            //BuscarerrorProvider1.Clear();
            LlenarClase(articulo);
            if (ValidarTextbox() && ValidarExiste(CodigoArticulotextBox.Text))
            {
                ArticuloBLL.Insertar(articulo);
                Limpiar();
                MessageBox.Show("Guardado con exito");
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
            a.Despcricion = DespcripciontextBox.Text;
            a.CantidadArticulo = int.Parse(CantidadArticulotextBox.Text);
            a.PrecioArticulo = int.Parse(PrecioArticulotextBox.Text);

        }
       
       
        private bool ValidarTextbox()
        {
            
            if (string.IsNullOrEmpty(CodigoArticulotextBox.Text) && string.IsNullOrEmpty(NombreArticulotextBox.Text) && string.IsNullOrEmpty(MarcaArticulotextBox.Text) && string.IsNullOrEmpty(DespcripciontextBox.Text) && string.IsNullOrEmpty(CantidadArticulotextBox.Text) && string.IsNullOrEmpty(PrecioArticulotextBox.Text))
            {
                //NombreUsuarioserrorProvider1.SetError(NombreUsuariostextBox, "Favor Ingresar El Nombre de Usuario");
               // ContraseñaerrorProvider1.SetError(ContraseñatextBox, "Favor ingresar la contraseña del usuario");
                //ConfimarContraseñaerrorProvider1.SetError(ConfimarContraseñatextBox1, "Favor confirmar comtraseña");
                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(CodigoArticulotextBox.Text))
            {
                //NombreUsuarioserrorProvider1.SetError(NombreUsuariostextBox, "Favor ingresar el nombre de Usuario");
                return false;
            }
            if (string.IsNullOrEmpty(NombreArticulotextBox.Text))
            {
                //NombreUsuarioserrorProvider1.SetError(NombreUsuariostextBox, "Favor ingresar el nombre de Usuario");
                return false;
            }

            if (string.IsNullOrEmpty(MarcaArticulotextBox.Text))
            {
               // NombreUsuarioserrorProvider1.Clear();
               // ConfimarContraseñaerrorProvider1.SetError(ConfimarContraseñatextBox1, "Favor ingresar la contraseña del usuario");
                return false;
            }

            if (string.IsNullOrEmpty(DespcripciontextBox.Text))
            {
               // NombreUsuarioserrorProvider1.Clear();
               // ContraseñaerrorProvider1.Clear();
               // ConfimarContraseñaerrorProvider1.SetError(ConfimarContraseñatextBox1, "Favor confirmar comtraseña");
                return false;
            }
            if (string.IsNullOrEmpty(CantidadArticulotextBox.Text))
            {
                // NombreUsuarioserrorProvider1.Clear();
                // ContraseñaerrorProvider1.Clear();
                // ConfimarContraseñaerrorProvider1.SetError(ConfimarContraseñatextBox1, "Favor confirmar comtraseña");
                return false;
            }
            if (string.IsNullOrEmpty(PrecioArticulotextBox.Text))
            {
                // NombreUsuarioserrorProvider1.Clear();
                // ContraseñaerrorProvider1.Clear();
                // ConfimarContraseñaerrorProvider1.SetError(ConfimarContraseñatextBox1, "Favor confirmar comtraseña");
                return false;
            }

            return true;
        }

    }
}
