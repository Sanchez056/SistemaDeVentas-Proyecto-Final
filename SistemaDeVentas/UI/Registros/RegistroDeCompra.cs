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
using SistemaDeVentas.Entidades;
using DAL;

namespace SistemaDeVentas.Registros
{
    public partial class RegistroDeCompra : Form
    {
        public List<Ventas> ventList = new List<Ventas>();
        Compras compra = new Compras();
        public List<Empleados> list = new List<Empleados>();
        public List<Articulos> lista = new List<Articulos>();
        Clientes cliente = new Clientes();
        UtilidadesInt utint = new UtilidadesInt();
        UtilidadesDouble utDouble = new UtilidadesDouble();
        public RegistroDeCompra()
        {
            InitializeComponent();
        }

        private void RegistroDeCompra_Load(object sender, EventArgs e)
        {
            CargarComboxEmpleados();
            CargarFiltrar();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BuscarComprabutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id de la compra que desea buscar") && ValidarBuscar())
                LLenar(BLL.CompraBLL.Buscar(ut.StringInt(FiltrarCompratextBox.Text)));
        }
        private void LLenar(Compras compra)
        {
            var comp = BLL.CompraBLL.Buscar(ut.StringInt(FiltrarCompratextBox.Text));
            FiltrarCompratextBox.Text = compra.CompraId.ToString();
            CodigoCompratextBox.Text = compra.Codigo;
            SubTotaltextBox.Text = compra.SubTotal.ToString();
            DescuentoTotaltextBox.Text = compra.TotalDescuento.ToString();
            TotalItebistextBox.Text =   compra.TotalItebis.ToString();
            TotaltextBox.Text = compra.Total.ToString();
            ArticulodataGridView.DataSource = null;
            ArticulodataGridView.DataSource = compra.Articulos;

            CargarComboxEmpleados();
        }
        private void CargarComboxEmpleados()
        {

            var db = new SistemaVentasDb();
            list = db.Empleados.ToList();
            if (list.Count > 0)
            {
                FiltrarEmpleadocomboBox.DataSource = list;
                FiltrarEmpleadocomboBox.ValueMember = "EmpleadoId";
                FiltrarEmpleadocomboBox.DisplayMember = "Nombre";
            }

        }

        UtilidadesInt ut = new UtilidadesInt();
        private bool ValidarBuscar()
        {
            if (BLL.CompraBLL.Buscar(ut.StringInt(FiltrarCompratextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(FiltrarCompratextBox.Text))
            {

                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Limpiar()
        {
            DateTimePicker f = new DateTimePicker();
            FiltrarArticulotextBox.Clear();
            FiltrarCompratextBox.Clear();
            CantidadtextBox.Clear();
            ImpuestotextBox.Clear();
            CategoriatextBox.Clear();
            DescripciontextBox.Clear();
            CodigotextBox.Clear();
            ProveedortextBox.Clear();
            FiltrarEmpleadocomboBox.DataSource = null;
            MarcatextBox.Clear();
            CodigotextBox.Clear();
            PreciotextBox.Clear();
            SubTotaltextBox.Clear();
            TotalItebistextBox.Clear();
            DescuentoTotaltextBox.Clear();
            TotaltextBox.Clear();
            DescuentotextBox.Clear();
            
            

            //-----
            // limpiarErroresProvider();

        }

        private void Nuevabutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BuscarArticulobutton_Click(object sender, EventArgs e)
        {
            BuscarSelecionComBox();
        }
        public void LlenarArticulo(Articulos articulos)
        {
            
            FiltrarArticulotextBox.Text = articulos.ArticuloId.ToString();
            NombretextBox.Text = articulos.Nombre;
            MarcatextBox.Text = articulos.Marca;
            DescripciontextBox.Text = articulos.Descripcion;
            CategoriatextBox.Text = articulos.Categoria;
            CantidadCompratextBox.Text = articulos.CantidadDispodible.ToString();
            PreciotextBox.Text = articulos.PrecioCompra.ToString();
            DescuentotextBox.Text = articulos.Descuento.ToString();
            CodigotextBox.Text = articulos.Codigo.ToString();
            
        }
        private bool ValidarBuscarArticulo()
        {
            if (ArticuloBLL.Buscar(ut.StringInt(FiltrarArticulotextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        private bool validarIdArticulo(string message)
        {
            if (string.IsNullOrEmpty(FiltrarArticulotextBox.Text))
            {

                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }
        //---------------------------------------------------



        //------------------------------------------------------
        private void CargarFiltrar()
        {
            FiltrarArticulocomboBox.Items.Insert(0, "ArticuloId");
            FiltrarArticulocomboBox.Items.Insert(1, "Nombre");
            FiltrarArticulocomboBox.Items.Insert(2, "Codigo");
            FiltrarArticulocomboBox.DataSource = FiltrarArticulocomboBox.Items;



        }
        private void BuscarSelecionComBox()
        {
            UtilidadesInt ut = new UtilidadesInt();


            if (FiltrarArticulocomboBox.SelectedIndex == 0)
            {

                if (validarIdArticulo("Favor ingresar el id de Articulo que desea buscar") && ValidarBuscarArticulo())
                    LlenarArticulo(ArticuloBLL.Buscar(ut.StringInt(FiltrarArticulotextBox.Text)));


            }
            if (FiltrarArticulocomboBox.SelectedIndex == 1)
            {

                {
                    if (!String.IsNullOrEmpty(FiltrarArticulotextBox.Text))
                    {


                        lista = ArticuloBLL.GetListaNombreArticulo(FiltrarArticulotextBox.Text);


                     

                    }
                    else
                    {
                        lista = ArticuloBLL.GetLista();
                    }

                    ArticulodataGridView.DataSource = lista;

                }
            }
            if (FiltrarArticulocomboBox.SelectedIndex == 2)
            {
                {

                    if (!String.IsNullOrEmpty(FiltrarArticulotextBox.Text))
                    {

                        lista = ArticuloBLL.GetListaCodigoArticulo(FiltrarArticulotextBox.Text);
                    }
                    else
                    {
                        lista = ArticuloBLL.GetLista();
                    }

                    ArticulodataGridView.DataSource = lista;
                }
            }






        }

        private void AsignarArticuloComprasgroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void InformacionArticulogroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            //compra.Articulos.Add(new Articulos(ut.StringInt(FiltrarArticulotextBox.Text), CodigotextBox.Text, NombretextBox.Text, MarcatextBox.Text, utDouble.StringDouble(PreciotextBox.Text)));
            ArticulodataGridView.DataSource = null;
            //ArticulodataGridView.DataSource = compra.Articulos;
            //ArticulodataGridView.Columns["Cantidad"].ReadOnly = false;
        }
        

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id de la compra  que desea eliminar") && ValidarBuscar())
            {
                BLL.CompraBLL.Eliminar(ut.StringInt(FiltrarCompratextBox.Text));
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }
        }

        private void Comprarbutton_Click(object sender, EventArgs e)
        {
            LlenarClase(compra);
            if (ValidarTextbox() && ValidarExiste(CodigoCompratextBox.Text))
            {
                BLL.CompraBLL.Insertar(compra);
                MessageBox.Show("Guardado con exito");
            }


        }
        private void  LlenarClase(Compras comp)
        {
           // comp.Codigo = CodigoCompratextBox.Text;

        }
        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(CodigoCompratextBox.Text)


                )
            {
                // NombreerrorProvider2.SetError(NombretextBox, "Favor Ingresar el Nombre de cliente");


                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(CodigoCompratextBox.Text))
            {
                // NombreerrorProvider2.Clear();
                //NombreerrorProvider2.SetError(NombretextBox, "Favor ingresar el Nombre del Cliente");
                return false;
            }
            return true;

        }
        private bool ValidarExiste(string aux)
        {
            if (BLL.CompraBLL.GetListaCodigo(aux).Count() > 0)
            {
                MessageBox.Show("Este codigo de compra  ya existe, favor intentar con otro codigo ...");
                return false;
            }
            return true;
        }

        private void Editarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor Buscar el Id para que desea actualizar") && ValidarTextbox())
            {

                LlenarClase(compra);
                if (ValidarExiste(CodigoCompratextBox.Text))
                {
                    BLL.CompraBLL.Modificar(ut.StringInt(FiltrarCompratextBox.Text), compra);
                    Limpiar();
                   // limpiarErroresProvider();
                    MessageBox.Show("Actualizado con exito");
                }

            }
        }
    }
        
}