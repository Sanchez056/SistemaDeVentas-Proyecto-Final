using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using BLL;
using Entidades;
namespace SistemaDeVentas
{
    public partial class LoginUsuarios : Form
    {
        MenuPrincipal MP = new MenuPrincipal();
        public LoginUsuarios()
        {
            Thread tardar = new Thread(new ThreadStart(PresentacionBar));
            tardar.Start();
            Thread.Sleep(8000);
            InitializeComponent();
            tardar.Abort();
        }
        //--

            public void PresentacionBar()
        {
            Application.Run(new Presentacion());
        }

        //--
        public bool ValidarExisteUsuario()
        {
            if (UsuariosBLL.GetListaNombreUsuario(NombreUsuariostextBox1.Text).Count() == 0)
            {
                MessageBox.Show("Este Usuario No Esta Registrado en El Sistema, por favor verifique que este Escrito correctamente, o Intentelo Con Nombre Usuario y Su Contraseñas...");
                return false;
            }

            return true;
        }
        //---
        public bool ValidarContraseña()
        {
            if (UsuariosBLL.getContraseña(ContraseñatextBox2.Text).Count() == 0)
            {
                MessageBox.Show("Contraseña incorrecta");
                return false;
            }

            return true;
        }
        //----
        public bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(NombreUsuariostextBox1.Text) && string.IsNullOrEmpty(ContraseñatextBox2.Text))
            {
                NombreUsuarioerrorProvider1.SetError(NombreUsuariostextBox1, "Favor ingresar el nombre de Usuario");
                ContraseñaerrorProvider2.SetError(ContraseñatextBox2, "Favor Ingresar la contraseña del Usuario");
                MessageBox.Show("Favor Llenar todos los campos Son obligatorios");

            }
            if (string.IsNullOrEmpty(NombreUsuariostextBox1.Text))
            {
               NombreUsuarioerrorProvider1.SetError(NombreUsuariostextBox1, "Favor ingresar el nombre de Usuario");
                return false;
            }

            if (string.IsNullOrEmpty(ContraseñatextBox2.Text))
            {
                NombreUsuarioerrorProvider1.Clear();
                ContraseñaerrorProvider2.SetError(ContraseñatextBox2, "Favor ingresar la contraseña del usuario");
                return false;
            }

            return true;

        }
        //---
        public DialogResult validarSesion()
        {
            if (ValidarTextbox() == true && ValidarExisteUsuario() == true && ValidarContraseña () == true)
            {

                return DialogResult.OK;
            }

            return DialogResult.Cancel;

        }
        //---
        private void IniciarSeccionbutton1_Click(object sender, EventArgs e)
        {
            if (validarSesion() == DialogResult.OK)
            {
                this.Visible = false;

                MP.Show();

            }
        }
    }
}
