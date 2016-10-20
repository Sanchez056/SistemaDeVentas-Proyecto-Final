using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
        }

        private void PresentacionprogressBar1_Click(object sender, EventArgs e)
        {
            //LoginUsuarios log = new LoginUsuarios();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.PresentacionprogressBar1.Increment(1);
            if (PresentacionprogressBar1.Value == 100)
                this.timer1.Stop();
        }
    }
}
