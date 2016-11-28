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

      
        public List<Clientes> lists = new List<Clientes>();
       
        private void RegistrosDeVentas_Load(object sender, EventArgs e)
        {
            CargarComboxEmpleados();
            CargarConboBoxClientes();
            CargarFiltrar();
            LLenarCombo();

           
           
        }
       

        public void Limpiar()
        {
            DateTimePicker f = new DateTimePicker();
            FiltrarArticulotextBox.Clear();
            FiltrarVentaIdtextBox.Clear();
            MarcatextBox.Clear();
            CodigoArticulotextBox.Clear();
            PreciotextBox.Clear();
            SubTotaltextBox.Clear();
            TotaltextBox.Clear();
            CodigoVentatextBox.Clear();
            DescuentotextBox.Clear();
            MontoDeudatextBox.Clear();
            CuotastextBox.Clear();
            NombretextBox.Clear();
            CantidadDipodibletextBox.Clear();
            ItebistextBox.Clear();
            ItebisTotaltextBox.Clear();
            TotalDescuntotextBox.Clear();
            ContadoradioButton.Checked = false;
            CreditoradioButton.Checked = false;
            DocFactuaradioButton.Checked = false;
            DocReciberadioButton.Checked = false;
            ArticulodataGridView.DataSource = null;
            ArticulodataGridView.Rows.Clear();
            //FechadateTimePicker.Value = f.Value;
            LimpiarErroresProvider();

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

        private void LLenar(Ventas v)
        {
           
            var vent = BLL.VentasBLL.Buscar(ut.StringInt(FiltrarVentaIdtextBox.Text));
            FiltrarVentaIdtextBox.Text = v.VentaId.ToString();
            if (ContadoradioButton.Checked == true)
            {
                v.CodicionPago = "Contado";
            }
            else
            {
                if (CreditoradioButton.Checked == true)
                    v.CodicionPago = "Credito";
                else
                    v.CodicionPago = "Nada";
            }
            MontoDeudatextBox.Text = v.Deuda.ToString();
            CodigoVentatextBox.Text = v.Codigo;
            CuotastextBox.Text = v.Cuota.ToString();
            ItebistextBox.Text = v.Itebis.ToString();
        
            ArticulodataGridView.DataSource = null;
            ArticulodataGridView.DataSource = v.Articulos;
            
            

            //v.Fecha = FechadateTimePicker.Value;

            
            CargarComboxEmpleados();
            CargarConboBoxClientes();
            
           
        }
        private void CargarCombobox()
        {
           
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
            BuscarArticuloserrorProvider.Clear();
            BuscarerrorProvider.Clear();
            LlenarClase(venta);
            if (ValidarTextbox() && ValidarExiste(CodigoArticulotextBox.Text))
            {
              
                BLL.VentasBLL.Insertar(venta);
                Limpiar();
                LimpiarErroresProvider();
                MessageBox.Show("Guardado con exito");
            }
          


        }
        private void LlenarClase(Ventas v)
        {
            v.Itebis = utDouble.StringDouble(ItebistextBox.Text);
            v.Cuota = utint.StringInt(CuotastextBox.Text);
            v.Deuda = utDouble.StringDouble(MontoDeudatextBox.Text);
            v.Codigo = CodigoVentatextBox.Text;

            if (ContadoradioButton.Checked == true)
            {
                v.CodicionPago = "Contado";      
            }
            else
            {
                if (CreditoradioButton.Checked == true)

                    v.CodicionPago = "Credito";
                
                else

                    v.CodicionPago = "Nada";
            }

           // v.FechaVencimiento = FechaVencimientodateTimePicker.Value;
            v.Fecha = FechadateTimePicker.Value;


            CargarComboxEmpleados();
            CargarConboBoxClientes();

        }
        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(CodigoVentatextBox.Text) )
                
            {
               CodigoerrorProvider.SetError(CodigoVentatextBox, "Favor Ingresar el codigo de la venta");
              
                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(CodigoVentatextBox.Text))
            {
                CodigoerrorProvider.Clear();
                CodigoerrorProvider.SetError(CodigoVentatextBox, "Favor ingresar el codigo de la venta");
                return false;
            }
            if (ContadoradioButton.Checked == false && CreditoradioButton.Checked == false)
            {
               ElegirCondicionPagoerrorProvider.SetError(CondiciondePagogroupBox, "Seleccionar condicion de pagos");
                return false;
            }
            if (DocReciberadioButton.Checked == false && DocFactuaradioButton.Checked == false)
            {
                TipoDocumentoerrorProvider.SetError(TipodeDocumentogroupBox, "Seleccionar el tipo de documentos");
                return false;
            }
            return true;

        }
        private bool ValidarExiste(string aux)
        {
            if (BLL.VentasBLL.GetListaCodigo(aux).Count() > 0)
            {
                MessageBox.Show("Este codigo de venta  ya existe, favor intentar con otro codigo o modificar el codigo ...");
                return false;
            }
            return true;
        }
        //---------------------------------------------------------------------

        private void BuscarArticulosbutton_Click(object sender, EventArgs e)
        {          
            BuscarSelecionComBox();
        }

        public void LlenarArticulo(Articulos articulos)
        {
            
            DescuentotextBox.Text = articulos.Descuento.ToString();
            NombretextBox.Text = articulos.Nombre;
            CantidadDipodibletextBox.Text = articulos.CantidadDispodible.ToString();
            MarcatextBox.Text = articulos.Marca;
            PreciotextBox.Text = articulos.PrecioVentas.ToString();
            CodigoArticulotextBox.Text = articulos.Codigo.ToString();
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

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id de la Venta  que desea eliminar") && ValidarBuscar())
            {
                BLL.VentasBLL.Eliminar(ut.StringInt(FiltrarVentaIdtextBox.Text));
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }
        }


        private void Agregarbutton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(FiltrarArticulotextBox.Text))
            {
                MessageBox.Show("El el Campo de busqueda de Articulos no tiene dato por favor ingresar un Id o Nombre o Codigo");
            }
            else
            {

                venta.Articulos.Add(new Articulos(ut.StringInt(FiltrarArticulotextBox.Text), CodigoArticulotextBox.Text, NombretextBox.Text, MarcatextBox.Text, utDouble.StringDouble(PreciotextBox.Text)));
                venta.Articulos.AddRange(lista);
                ArticulodataGridView.DataSource = null;
                ArticulodataGridView.DataSource = venta.Articulos;
            
              
            }
            

        }

        private void LimpiarErroresProvider()
        {
            CodigoerrorProvider.Clear();
            ElegirCondicionPagoerrorProvider.Clear();
            TipoDocumentoerrorProvider.Clear();
        }


        private void LLenarCombo()
        {
            ArticuloScomboBox.DataSource = ArticuloBLL.GetLista();
            ArticuloScomboBox.DisplayMember = "Nombre";
            ArticuloScomboBox.ValueMember = "ArticuloId";



        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
       
        private void ContadoradioButton_CheckedChanged(object sender, EventArgs e)
        {
                     
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {


        }

        private void FiltrarVentaIdtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quitarbutton_Click(object sender, EventArgs e)
        {
            


        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {

        }
        private void BuscarClientebutton_Click(object sender, EventArgs e)
        {

        }


        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void Editarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor Buscar el Id para que desea actualizar") && ValidarTextbox())
            {

                LlenarClase(venta);
                if (ValidarExiste(CodigoVentatextBox.Text))
                {
                    BLL.VentasBLL.Modificar(ut.StringInt(FiltrarVentaIdtextBox.Text), venta);
                    Limpiar();
                    LimpiarErroresProvider();
                    MessageBox.Show("Actualizado con exito");
                }

            }
        }
    }

}
    

