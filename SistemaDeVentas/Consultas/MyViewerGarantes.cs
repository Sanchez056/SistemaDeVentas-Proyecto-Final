using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas.Consultas
{
    public partial class MyViewerGarantes : Form
    {
        public MyViewerGarantes()
        {
            InitializeComponent();
        }

        private void MyViewerGarantes_Load(object sender, EventArgs e)
        {

            this.GarantesreportViewer.RefreshReport();
        }
    }
}
