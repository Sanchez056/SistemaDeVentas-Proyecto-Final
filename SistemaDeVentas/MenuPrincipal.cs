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
            ResArt.Location = new Point(130, 10);

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroDeUsuarios ResUs = new RegistroDeUsuarios();

            ResUs.MdiParent = this;
            ResUs.Show();
            ResUs.Location = new Point(130, 10);
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaUsuarios consulta= new Consultas.ConsultaUsuarios();

            consulta.MdiParent = this;
            consulta.Show();
            consulta.Location = new Point(130, 10);
        }

        private void ConsultaarticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultasArticulos consulta = new Consultas.ConsultasArticulos();
            consulta.MdiParent = this;
            consulta.Show();
            consulta.Location = new Point(130, 10);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistrosclientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            RegistroDeClientes resCli = new RegistroDeClientes();


            resCli.MdiParent = this;
            resCli.Show();
            resCli.Location = new Point(130, 10);

        }

        private void registrosEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void RegistrosproveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistroDeProveedores regisProvee = new Registros.RegistroDeProveedores();

            regisProvee.MdiParent = this;
            regisProvee.Show();
            regisProvee.Location = new Point(130, 10);


        }

        private void garanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistrosGarantes regGarante = new Registros.RegistrosGarantes();

            regGarante.MdiParent = this;
            regGarante.Show();
            regGarante.Location =  new Point(130, 10);
        }

        private void ConsultaclientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaClientes consulta= new Consultas.ConsultaClientes();

            consulta.MdiParent = this;
            consulta.Show();
            consulta.Location = new Point(130, 10);
        }

        private void ConsultaproveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaProveedores consulta = new Consultas.ConsultaProveedores();

            consulta.MdiParent = this;
            consulta.Show();
            consulta.Location = new Point(130, 10);
        }

        private void garantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaGarantes consulta = new Consultas.ConsultaGarantes();

            consulta.MdiParent = this;
            consulta.Show();
            consulta.Location = new Point(130, 10);
        }
    }
}


