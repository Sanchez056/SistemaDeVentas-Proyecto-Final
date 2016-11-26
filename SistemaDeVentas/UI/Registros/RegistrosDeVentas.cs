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
using DAL;
using BLL;
using SistemaDeVentas.Entidades;

namespace SistemaDeVentas.UI.Registros
{
    public partial class RegistrosDeVentas : Form
    {
        public List<Ventas> ventList = new List<Ventas>();
        public List<Empleados> list = new List<Empleados>();
        public List<Articulos> lista = new List<Articulos>();
        Ventas venta = new Ventas();
        Clientes cliente = new Clientes();
        UtilidadesInt utint = new UtilidadesInt();
        UtilidadesDouble utDouble = new UtilidadesDouble();
        public RegistrosDeVentas()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        public List<Clientes> lists = new List<Clientes>();
        private void BuscarClientebutton_Click(object sender, EventArgs e)
        {

        }


        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void RegistrosDeVentas_Load(object sender, EventArgs e)
        {
            CargarComboxEmpleados();
            CargarConboBoxClientes();
            CargarFiltrar();
        }
        public void LlenarClase()
        {

        }


        public void Limpiar()
        {
            DateTimePicker f = new DateTimePicker();
            FiltrarArticulotextBox.Clear();
            FiltrarVentaIdtextBox.Clear();
            MarcatextBox.Clear();
            CodigotextBox.Clear();
            PreciotextBox.Clear();
            SubTotaltextBox.Clear();
            TotaltextBox.Clear();
            DescuentotextBox.Clear();
            MontoDeudatextBox.Clear();
            CuotastextBox.Clear();
            FechaVencmaskedTextBox.Clear();
            ItebistextBox.Clear();
            ItebisTotaltextBox.Clear();
            TotalDescuntotextBox.Clear();
            ContadoradioButton.Checked = false;
            CreditoradioButton.Checked = false;
            DocFactuaradioButton.Checked = false;
            DocReciberadioButton.Checked = false;
            //FechadateTimePicker.Value = f.Value;

            //-----
            // limpiarErroresProvider();

        }

        private void Nuevabutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BuscarIdbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id de la Venta que desea buscar") && ValidarBuscar())
                LLenar(BLL.VentasBLL.Buscar(ut.StringInt(FiltrarVentaIdtextBox.Text)));
        }

        private void LLenar(Ventas venta)
        {
             //Clientes cliente = new Clientes();
            FiltrarVentaIdtextBox.Text = venta.VentaId.ToString();
            
            CuotastextBox.Text = venta.Cuotas.ToString();
            MontoDeudatextBox.Text = venta.Deuda.ToString();
            SubTotaltextBox.Text = venta.SubTotal.ToString();
            TotalDescuntotextBox.Text = venta.TotalDescuento.ToString();
            ItebisTotaltextBox.Text = venta.TotalItebis.ToString();
            TotaltextBox.Text = venta.Total.ToString();
            if (venta.CodicionPago == "Contado")
                ContadoradioButton.Checked = true;
            if (venta.CodicionPago == "Credito")
                CreditoradioButton.Checked = true;

         
            CargarComboxEmpleados();
            CargarConboBoxClientes();
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
         public List<Clientes> listas = new List<Clientes>();
        private void CargarConboBoxClientes()
        {
            var db = new SistemaVentasDb();
            listas = db.Clientes.ToList();
            if (listas.Count > 0)
            {
                FiltrarClientecomboBox.DataSource = listas;
                FiltrarClientecomboBox.ValueMember = "ClienteId";
                FiltrarClientecomboBox.DisplayMember = "Nombre";
            }
        }


        UtilidadesInt ut = new UtilidadesInt();
        private bool ValidarBuscar()
        {
            if (BLL.VentasBLL.Buscar(ut.StringInt(FiltrarVentaIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(FiltrarVentaIdtextBox.Text))
            {

                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void EmpleadogroupBox_Enter(object sender, EventArgs e)
        {
           
        }

        private void RefrecarVentanabutton_Click(object sender, EventArgs e)
        {

        }

        private void Cobrarbutton_Click(object sender, EventArgs e)
        {

        }
        private void LlenarClase(Ventas v)
        {




        }
        //---------------------------------------------------------------------------------------

        private void BuscarArticulosbutton_Click(object sender, EventArgs e)
        {
            //if (validarIdArticulo("Favor ingresar el id de Articulo que desea buscar") && ValidarBuscarArticulo())
           //  LlenarArticulo(ArticuloBLL.Buscar(ut.StringInt(FiltrarArticulotextBox.Text)));

            BuscarSelecionComBox();
        }

        public void LlenarArticulo(Articulos articulos)
        {
            // return false;

           // FiltrarArticulotextBox.Text = articulos.Nombre.ToString();
            DescuentotextBox.Text = articulos.Descuento.ToString();
            NombretextBox.Text = articulos.Nombre;
            CantidadDipodibletextBox.Text = articulos.Cantidad.ToString();
            MarcatextBox.Text = articulos.Marca;
            PreciotextBox.Text = articulos.PrecioVentas.ToString();
            CodigotextBox.Text = articulos.Codigo.ToString();
            // DescuentotextBox.Text = venta.descuento.ToString();

            // return true;
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
                        

                        //lista =''
                      
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
       
        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            venta.Articulos.Add(new Articulos(ut.StringInt(FiltrarArticulotextBox.Text), CodigotextBox.Text, NombretextBox.Text, MarcatextBox.Text, utDouble.StringDouble(PreciotextBox.Text)));
            ArticulodataGridView.DataSource = null;
            ArticulodataGridView.DataSource = venta.Articulos;
            ArticulodataGridView.Columns["Cantidad"].ReadOnly = false;



        }
        private void SumOpcion2()
        {
            Ventas venta = new Ventas();
            //decimal total = 0;
            if (ArticulodataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in ArticulodataGridView.Rows)
                {
                    venta.Total += Convert.ToDouble(row.Cells["columnPrecio"].Value);
                }
            }

            TotaltextBox.Text = Convert.ToString(venta.Total);
        }

        private void ContadoradioButton_CheckedChanged(object sender, EventArgs e)
        {
                     
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {


        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id de la Venta  que desea eliminar") && ValidarBuscar())
            {
                BLL.VentasBLL.Eliminar(ut.StringInt(FiltrarVentaIdtextBox.Text));
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }
        }
    }

}
    

