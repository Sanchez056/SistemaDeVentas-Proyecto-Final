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

namespace SistemaDeVentas.UI.Registros
{
    public partial class RegistrosTipoUsuarios : Form
    {
        Utilidades ut = new Utilidades();
        public RegistrosTipoUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del usuario que desea buscar") && ValidarBuscar())
                LLenar(TiposUsuariosBLL.Buscar(ut.StringInt(TipoUsuarioIdtextBox.Text)));

        }
        private void LLenar(TipoUsuarios tipoUs)
        {

            TipoUsuarioIdtextBox.Text = tipoUs.TipoUsuarioId.ToString();
            NombretextBox.Text = tipoUs.Detalle;
        }


        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(TipoUsuarioIdtextBox.Text))
            {
                BuscarerrorProvider.SetError(TipoUsuarioIdtextBox, "Por Favor Ingresar Id");
                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ValidarBuscar()
        {
            if (TiposUsuariosBLL.Buscar(ut.StringInt((TipoUsuarioIdtextBox.Text))) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }

        private void RegistrosTipoUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            TipoUsuarioIdtextBox.Clear();
            NombretextBox.Clear();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TipoUsuarios tipUs = new TipoUsuarios();
            BuscarerrorProvider.Clear();
            LlenarClase(tipUs);
            if (ValidarTextbox() && ValidarExiste(NombretextBox.Text))
            {
              TiposUsuariosBLL.Insertar(tipUs);
                Limpiar();
                MessageBox.Show("Guardado con exito");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id del usuario que desea eliminar") && ValidarBuscar())
            {
                UsuariosBLL.Eliminar(ut.StringInt(TipoUsuarioIdtextBox.Text));
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }
        }
        private void LlenarClase(TipoUsuarios tipu)
        {
            tipu.Detalle= NombretextBox.Text;
          ;

        }
        //---

      


        private bool ValidarExiste(string aux)
        {
            if (TiposUsuariosBLL.GetLista(aux).Count() > 0)
            {
                MessageBox.Show("Este nombre de Usuario ya existe, favor intentar con otro nombre de usario...");
                return false;
            }
            return true;
        }

        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                NombreerrorProvider.SetError(NombretextBox, "Favor Ingresar El Nombre de Usuario");
                
                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                NombreerrorProvider.SetError(NombretextBox, "Favor ingresar el nombre de Usuario");
                return false;
            }

           
            return true;
        }
    }
}
