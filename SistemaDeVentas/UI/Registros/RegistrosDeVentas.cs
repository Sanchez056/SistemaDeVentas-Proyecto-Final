using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas.UI.Registros
{
    public partial class RegistrosDeVentas : Form
    {
        public RegistrosDeVentas()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            Extras.Calculadoras ca = new Extras.Calculadoras();
            ca.MdiParent = this;
            ca.Show();
            ca.Location = new Point(40, 40);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if

                 (MessageBox.Show("Seguro que decea cobrar y guardar factura", "Decision", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

               
                MessageBox.Show("");
            }
        }

        private void BuscarClientebutton_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
