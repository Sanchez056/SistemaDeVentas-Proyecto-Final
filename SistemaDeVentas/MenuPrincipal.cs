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

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void registrarUsuairoToolStripMenuItem_Click(object sender, EventArgs e)
        {



            

           
           

        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
           
        }

        private void registrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RegistroDeUsuarios rUsuarios = new RegistroDeUsuarios();
            rUsuarios.MdiParent = this;
            rUsuarios.Show();

        }
    }
}


