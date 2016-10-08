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
using DAL;
using BLL;

namespace SistemaDeVentas
{
    public partial class RegistroDeUsuarios : Form
    {
        public RegistroDeUsuarios()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            BuscarerrorProvider1.Clear();
            LlenarClase(usuario);
            if (ValidarTextbox() && ValidarExiste(NombreUsuariostextBox.Text))
            {
                UsuariosBLL.Insertar(usuario);
                Limpiar();
                MessageBox.Show("Guardado con exito");
            } 

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            IdUsuariotextBox.Clear();
            NombreUsuariostextBox.Clear();
            ContraseñatextBox.Clear();
            ConfimarContraseñatextBox1.Clear();
            TipoUsuarioscomboBox.Text = "Selecion de Opciones";
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del usuario que desea buscar") && ValidarBuscar())
                LLenar(UsuariosBLL.Buscar(String(IdUsuariotextBox.Text)));
        }
        private void LLenar(Usuarios usuario)
        {
            IdUsuariotextBox.Text = usuario.IdUsuario.ToString();
            NombreUsuariostextBox.Text = usuario.NombreUsuario;
            ContraseñatextBox.Text = usuario.Contrasena;
            ConfimarContraseñatextBox1.Text = usuario.Contrasena;
            //TipoUsuarioscomboBox.Text = usuario.TipoUsuarios;

        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(IdUsuariotextBox.Text))
            {
                 BuscarerrorProvider1.SetError(IdUsuariotextBox, "Por Favor Ingresar Id");
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
            if (UsuariosBLL.Buscar(String(IdUsuariotextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;

            }

            return true;


        }
        public int String(string texto)
        {
            int numero = 0;

            int.TryParse(texto, out numero);

            return numero;
        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            if (validarId("Favor Buscar el Usuarios que se Modificar") && ValidarTextbox())
            {

                LlenarClase(usuario);
                if (ValidarExiste(NombreUsuariostextBox.Text))
                {
                    UsuariosBLL.Modificar(String(IdUsuariotextBox.Text), usuario);
                    Limpiar();
                    MessageBox.Show("La Modificacion Fue Todo un Exito");
                }

            }
        }
        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty( NombreUsuariostextBox.Text) && string.IsNullOrEmpty(ContraseñatextBox.Text) && string.IsNullOrEmpty(ConfimarContraseñatextBox1.Text))
            {
                NombreUsuarioserrorProvider1.SetError(NombreUsuariostextBox, "Favor Ingresar El Nombre de Usuario");
                ContraseñaerrorProvider1.SetError(ContraseñatextBox, "Favor ingresar la contraseña del usuario");
                ConfimarContraseñaerrorProvider1.SetError(ConfimarContraseñatextBox1, "Favor confirmar comtraseña");
                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(NombreUsuariostextBox.Text))
            {
               NombreUsuarioserrorProvider1.SetError(NombreUsuariostextBox, "Favor ingresar el nombre de Usuario");
                return false;
            }

            if (string.IsNullOrEmpty(ContraseñatextBox.Text))
            {
               NombreUsuarioserrorProvider1.Clear();
               ConfimarContraseñaerrorProvider1.SetError(ConfimarContraseñatextBox1, "Favor ingresar la contraseña del usuario");
                return false;
            }

            if (string.IsNullOrEmpty(ContraseñatextBox.Text))
            {
                   NombreUsuarioserrorProvider1.Clear();
                   ContraseñaerrorProvider1.Clear();
                ConfimarContraseñaerrorProvider1.SetError(ConfimarContraseñatextBox1, "Favor confirmar comtraseña");
                return false;
            }

            if (ContraseñatextBox.Text != ConfimarContraseñatextBox1.Text)
            {
                NombreUsuarioserrorProvider1.Clear();
                ContraseñaerrorProvider1.Clear();
                ConfimarContraseñaerrorProvider1.Clear();
                ConfimarContraseñaerrorProvider1.SetError(ConfimarContraseñatextBox1, "La contraseña no coincide");
                //MessageBox.Show("La Contraseña no conciden");
                return false;
            }



            return true;




        }
        private bool ValidarExiste(string aux)
        {
            if (UsuariosBLL.GetListaNombreUsuario(aux).Count() > 0)
            {
                MessageBox.Show("Este nombre de Usuario ya existe, favor intentar con otro nombre de usario...");
                return false;
            }
            return true;
        }
        private void LlenarClase(Usuarios u)
        {
            u.NombreUsuario = NombreUsuariostextBox.Text;
            u.Contrasena = ContraseñatextBox.Text;

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

            if (validarId("Favor digitar el id del usuario que desea eliminar") && ValidarBuscar())
            {
                UsuariosBLL.Eliminar(String(IdUsuariotextBox.Text));
               // limpiarErrores();
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }
        }

        private void RegistroDeUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
