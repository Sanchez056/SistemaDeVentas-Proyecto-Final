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

namespace SistemaDeVentas.Consultas
{
    public partial class ConsultaUsuarios : Form
    {
        public ConsultaUsuarios()
        {
            InitializeComponent();
        }

        Utilidades ut = new Utilidades();
        public List<Usuarios> lista = new List<Usuarios>();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar() == true)
                BuscarSelecionComBox();
        }
        private void CargarFiltrar()
        {
            FiltrarcomboBox.Items.Insert(0, "UsuarioId");
            FiltrarcomboBox.Items.Insert(1, "Nombre");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Id";
            ConsultaUsuariosdataGridView.DataSource = BLL.UsuariosBLL.GetLista();
        }

        private void BuscarSelecionComBox()
        {
            Utilidades ut = new Utilidades();


            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = BLL.UsuariosBLL.GetLista(ut.StringInt(FiltrotextBox.Text));
                }
                else
                {
                    lista = BLL.UsuariosBLL.GetLista();
                }

                ConsultaUsuariosdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = BLL.UsuariosBLL.GetListaNombreUsuario(FiltrotextBox.Text);
                }
                else
                {
                    lista = BLL.UsuariosBLL.GetLista();
                }

                ConsultaUsuariosdataGridView.DataSource = lista;
            }
           
        }

        private bool validar()
        {
            Utilidades ut = new Utilidades();

            
                
            
            if (string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                BuscarerrorProvider.SetError(FiltrotextBox, "Ingresar el campo que desea filtar");
                return false;
            }

            if (FiltrarcomboBox.SelectedIndex == 0 && BLL.UsuariosBLL.GetLista(ut.StringInt(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }

            if (FiltrarcomboBox.SelectedIndex == 1 && BLL.UsuariosBLL.GetListaNombreUsuario(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }
            
            

           

            BuscarerrorProvider.Clear();


            return true;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            MyViewerUsuarios viewer = new MyViewerUsuarios();

            viewer.UsuariosreportViewer.Reset();
            viewer.UsuariosreportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            viewer.UsuariosreportViewer.LocalReport.ReportPath = @"D:\Origen Sistema De Ventas\SistemaDeVentas\SistemaDeVentas\Reportes\ListadosUsuarios.rdlc";


            viewer.UsuariosreportViewer.LocalReport.DataSources.Clear();


            viewer.UsuariosreportViewer.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSetUsuarios",
                BLL.UsuariosBLL.GetLista()));

            viewer.UsuariosreportViewer.LocalReport.Refresh();

            viewer.Show();
        }

        private void ConsultaUsuarios_Load(object sender, EventArgs e)
        {
            CargarFiltrar();
        }
    }
}
