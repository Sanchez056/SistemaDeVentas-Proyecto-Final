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
    public partial class ConsultasArticulos : Form
    {
        public ConsultasArticulos()
        {
            InitializeComponent();
        }

        public List<Articulos> lista = new List<Articulos>();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
              
            Utilidades ut = new Utilidades();
             if (!String.IsNullOrEmpty(FiltrotextBox.Text))
            {

                lista = BLL.ArticuloBLL.GetLista(ut.StringInt(FiltrotextBox.Text));
            }
            else
            {
                lista = BLL.ArticuloBLL.GetLista();
            }

            ConsultaArticulosdataGridView.DataSource = lista;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            MyViewerArticulos viewer = new MyViewerArticulos();

            viewer.ArticulosreportViewer.Reset();
            viewer.ArticulosreportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            viewer.ArticulosreportViewer.LocalReport.ReportPath = @"D:\Origen Sistema De Ventas\SistemaDeVentas\SistemaDeVentas\Reportes\ListadoArticulos";

            viewer.ArticulosreportViewer.LocalReport.DataSources.Clear();


            viewer.ArticulosreportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetArticulo", lista));

            viewer.ArticulosreportViewer.LocalReport.Refresh();

            viewer.Show();
        }
    }
}
