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

namespace SistemaDeVentas.UI.Registros
{
    public partial class RegistrosCategoriaArticulos : Form
    {
        public RegistrosCategoriaArticulos()
        {
            InitializeComponent();
        }

        private void Quitarbutton_Click(object sender, EventArgs e)
        {

        }
        public void Limpiar()
        {
            CategoriaIdtextBox.Clear();
            DescripciontextBox.Clear();

        }
        Entidades.Articulos art = new Entidades.Articulos();

        Categorias categoria = new Categorias();
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            
            //BuscarerrorProvider1.Clear();
            LlenarClase(categoria);
           
            if (ValidarTextbox() && ValidarExiste(CategoriaIdtextBox.Text))
            {
                BLL.CategoriaBLL.Insertar(categoria);
                Limpiar();
                MessageBox.Show("Guardado con exito");
            }
        }

        private void LLenar(Categorias categoria)
        {
           
            CategoriaIdtextBox.Text = categoria.CategoriaId.ToString();
            DescripciontextBox.Text = categoria.Descripcion;
        }
        Utilidades ut = new Utilidades();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id de la Categoria que desea buscar") && ValidarBuscar())
                LLenar(BLL.CategoriaBLL.Buscar(ut.StringInt(CategoriaIdtextBox.Text)));
        }
        private bool ValidarBuscar()
        {
            if (BLL.CategoriaBLL.Buscar(ut.StringInt(CategoriaIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(CategoriaIdtextBox.Text))
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
            if (BLL.CategoriaBLL.GetListaDescripcion(aux).Count() > 0)
            {
                MessageBox.Show("Este Categoria ya  existe, favor intentar con otra Descripcion de Categoria ...");
                return false;
            }
            return true;
        }
        private void LlenarClase(Categorias c)
        {   
            c.Descripcion= DescripciontextBox.Text;     
        }


        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(DescripciontextBox.Text) 
                

                )
            {
                // NombreerrorProvider2.SetError(CodigoArticulotextBox, "Favor Ingresar el codigo de articulo");

                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(DescripciontextBox.Text))
            {
                // NombreerrorProvider2.Clear();
                //NombreerrorProvider2.SetError(CodigoArticulotextBox, "Favor ingresar el Nombre de codigo del articulo");
                return false;
            }
           
           

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id de la Categoria que desea eliminar") && ValidarBuscar())
            {
                BLL.CategoriaBLL.Eliminar(ut.StringInt(CategoriaIdtextBox.Text));
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }
        }
       

        private void RegistrosCategoriaArticulos_Load(object sender, EventArgs e)
        {
          
        }

       
    }
}
