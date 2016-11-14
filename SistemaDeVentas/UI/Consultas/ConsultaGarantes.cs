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

namespace SistemaDeVentas.Consultas
{
    public partial class ConsultaGarantes : Form
    {
        public ConsultaGarantes()
        {
            InitializeComponent();
        }

        public List<Garantes> lista = new List<Garantes>();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar() == true)
                BuscarSelecionComBox();
        }

        private void CargarFiltrar()
        {
            FiltrarcomboBox.Items.Insert(0, "GaranteId");
            FiltrarcomboBox.Items.Insert(1, "Nombre");
            FiltrarcomboBox.Items.Insert(2, "Apellido");
            FiltrarcomboBox.Items.Insert(3, "Cedula");
            FiltrarcomboBox.Items.Insert(4, "Sexo");
            FiltrarcomboBox.Items.Insert(5, "FechaIngreso");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Id";
            ConsultaGarantesdataGridView.DataSource = GaranteBLL.GetLista();
        }

        private void BuscarSelecionComBox()
        {
            Utilidades ut = new Utilidades();


            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = GaranteBLL.GetLista(ut.StringInt(FiltrotextBox.Text));
                }
                else
                {
                    lista = GaranteBLL.GetLista();
                }

                ConsultaGarantesdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = GaranteBLL.GetListaNombreGarantes(FiltrotextBox.Text);
                }
                else
                {
                    lista = GaranteBLL.GetLista();
                }

                ConsultaGarantesdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 2)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = GaranteBLL.GetListaApellido(FiltrotextBox.Text);
                }
                else
                {
                    lista = GaranteBLL.GetLista();
                }

                ConsultaGarantesdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 3)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = GaranteBLL.GetListaCedula(FiltrotextBox.Text);
                }
                else
                {
                    lista = GaranteBLL.GetLista();
                }

                ConsultaGarantesdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 4)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = GaranteBLL.GetListaSexo(FiltrotextBox.Text);
                }
                else
                {
                    lista = GaranteBLL.GetLista();
                }

                 ConsultaGarantesdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 5)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = GaranteBLL.GetListaFecha(DesdeDateTimePicke.Value, HastadateTimePicker.Value);
                }
                else
                {
                    lista = GaranteBLL.GetLista();
                }

                ConsultaGarantesdataGridView.DataSource = lista;
            }



        }

        private bool validar()
        {
            Utilidades ut = new Utilidades();

            if (FiltrarcomboBox.SelectedIndex == 5)
            {
                if (DesdeDateTimePicke.Value == HastadateTimePicker.Value)
                {
                    MessageBox.Show("Favor definir un intervalo diferente entre las dos fechas");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            if (string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                BuscarerrorProvider.SetError(FiltrotextBox, "Ingresar el campo que desea filtar");
                return false;
            }


            if (FiltrarcomboBox.SelectedIndex == 1 && GaranteBLL.GetListaNombreGarantes(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }
            if (FiltrarcomboBox.SelectedIndex == 2 && GaranteBLL.GetListaApellido(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }
            if (FiltrarcomboBox.SelectedIndex == 3 && GaranteBLL.GetListaCedula(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }
            if (FiltrarcomboBox.SelectedIndex == 4 && GaranteBLL.GetListaSexo(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }

            if (FiltrarcomboBox.SelectedIndex == 0 && GaranteBLL.GetLista(ut.StringInt(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }

            BuscarerrorProvider.Clear();


            return true;
        }

        private void ConsultaGarantes_Load(object sender, EventArgs e)
        {
            CargarFiltrar();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            MyViewerGarantes viewer = new MyViewerGarantes();

            viewer.GarantesreportViewer.Reset();
            viewer.GarantesreportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            viewer.GarantesreportViewer.LocalReport.ReportPath = @"D:\Origen Sistema De Ventas\SistemaDeVentas\SistemaDeVentas\UI\Reportes\ListadoGarantes.rdlc";


            viewer.GarantesreportViewer.LocalReport.DataSources.Clear();


            viewer.GarantesreportViewer.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSetGarantes",
                GaranteBLL.GetLista()));

            viewer.GarantesreportViewer.LocalReport.Refresh();

            viewer.Show();
        }
    }
}
