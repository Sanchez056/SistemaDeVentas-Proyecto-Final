using Microsoft.Win32;
using SistemaDeVentas;
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
    public partial class MenuPrincipal : Form
    {
        
        RegistroDeUsuarios Rus = new RegistroDeUsuarios();
       
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void articuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrosArticulo ResArt = new RegistrosArticulo();

            ResArt.MdiParent = this;
            ResArt.Show();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroDeUsuarios ResUs = new RegistroDeUsuarios();

            ResUs.MdiParent = this;
            ResUs.Show();
        }
    }
}


