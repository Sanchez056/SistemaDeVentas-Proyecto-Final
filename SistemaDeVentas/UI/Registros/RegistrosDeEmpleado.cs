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

namespace SistemaDeVentas.Registros
{
    public partial class RegistrosDeEmpleado : Form
    {
        public RegistrosDeEmpleado()
        {
            InitializeComponent();
        }

        private void FechadateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del Empleado que desea buscar") && ValidarBuscar())
                LLenar(EmpleadosBLL.Buscar(ut.StringInt(EmpleadoIdtextBox.Text)));
        }
        private void LLenar(Empleados empleado)
        {

            EmpleadoIdtextBox.Text = empleado.EmpleadoId.ToString();
            NombretextBox.Text = empleado.Nombre;
            ApellidotextBox.Text = empleado.Apellido;
            CiudadcomboBox.Text = empleado.Ciudad;
            DirecciontextBox.Text = empleado.Direccion;
            CedulamaskedTextBox.Text = empleado.Cedula;
            TelefonomaskedTextBox1.Text = empleado.Telefono;
            CelularmaskedTextBox2.Text =empleado.Celular;
            if (empleado.Sexo == "M")
                MasculinocheckBox.Checked = true;
            if (empleado.Sexo == "F")
                FemeninocheckBox.Checked = true;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        Empleados empleado = new Empleados();
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
         
            //BuscarerrorProvider1.Clear();
            LlenarClase(empleado);
            if (ValidarTextbox() && ValidarExiste(CedulamaskedTextBox.Text))
            {
                EmpleadosBLL.Insertar(empleado);
                Limpiar();
                limpiarErroresProvider();
                MessageBox.Show("-_-Guardado Con Exito-_-");
            }
        }
         private bool ValidarExiste(string aux)
        {
            if (EmpleadosBLL.GetListaCedula(aux).Count() > 0)
            {
                MessageBox.Show("Este cedula de Empleado ya existe, favor intentar con otra Cedula ...");
                return false;
            }
            return true;
        }
        Utilidades ut = new Utilidades();
        private bool ValidarBuscar()
        {
            if (EmpleadosBLL.Buscar(ut.StringInt(EmpleadoIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(EmpleadoIdtextBox.Text))
            {

                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void LlenarClase(Empleados e)
        {

            e.Nombre = NombretextBox.Text;
            e.Apellido = ApellidotextBox.Text;
            e.Cedula = CedulamaskedTextBox.Text;
            e.Ciudad = CiudadcomboBox.Text;
            e.Direccion = DirecciontextBox.Text;
            e.FechaNacimiento = FechaNacimientomaskedTextBox.Text;
            e.Telefono = TelefonomaskedTextBox1.Text;
            e.Celular = CelularmaskedTextBox2.Text;
            if (MasculinocheckBox.Checked == true)
            {
                e.Sexo = "M";
            }
            else
            {
                if (FemeninocheckBox.Checked == true)

                    e.Sexo = "F";
                else

                    e.Sexo = "M";
            }

            e.FechaIngreso = FechadateTimePicker.Value;


        }


        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(NombretextBox.Text) &&
                string.IsNullOrEmpty(ApellidotextBox.Text) &&
                string.IsNullOrEmpty(CedulamaskedTextBox.Text) &&
                string.IsNullOrEmpty(DirecciontextBox.Text) &&
                string.IsNullOrEmpty(TelefonomaskedTextBox1.Text) &&
                string.IsNullOrEmpty(CelularmaskedTextBox2.Text)

                )
            {
               // NombreerrorProvider2.SetError(NombretextBox, "Favor Ingresar el Nombre de Empleado");
               // ApellidoerrorProvider3.SetError(ApellidotextBox, "Favor Ingresar el Apellido de Empleado");
               // CedulaerrorProvider4.SetError(CedulamaskedTextBox, "Favor Ingresar la Cedula Empleado");
               // CiudaderrorProvider7.SetError(CiudadcomboBox, "Favor Ingresar la Ciudad actual de donde recide el Empleado");
               // DirrecionerrorProvider8.SetError(DirecciontextBox, "Favor Ingresar la Dirrecion de la ciudad de donde esta el Empleado");
               // TelefonoerrorProvider9.SetError(TelefonomaskedTextBox1, "Favor Ingresar el Numero de Telefono Recidencia del Empleado");
               // CedulaerrorProvider4.SetError(CedulamaskedTextBox, "Favor Ingresarel Numero de Celular de Empleado");

                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
              //  NombreerrorProvider2.Clear();
               // NombreerrorProvider2.SetError(NombretextBox, "Favor ingresar el Nombre del Empleado");
                return false;
            }
            if (string.IsNullOrEmpty(ApellidotextBox.Text))
            {
               // ApellidoerrorProvider3.Clear();
               // ApellidoerrorProvider3.SetError(ApellidotextBox, "Favor ingresar el Apellido del Empleado");
                return false;
            }

            if (string.IsNullOrEmpty(CedulamaskedTextBox.Text))
            {
                //CedulaerrorProvider4.Clear();
               // CedulaerrorProvider4.SetError(CedulamaskedTextBox, "Favor ingresar el Numero de Cedula de Identidad");
                return false;
            }
            if (string.IsNullOrEmpty(CiudadcomboBox.Text))
            {
               // CiudaderrorProvider7.Clear();
               // CiudaderrorProvider7.SetError(CiudadcomboBox, "Favor ingrese la Ciudad que Actual de Empleado");
                return false;
            }
            if (string.IsNullOrEmpty(DirecciontextBox.Text))
            {
               // DirecciontextBox.Clear();
               // DirrecionerrorProvider8.SetError(DirecciontextBox, "Favor ingrese la dirrecion de la ciudad de donde vive Empleado");
                return false;
            }

            if (string.IsNullOrEmpty(TelefonomaskedTextBox1.Text))
            {
                //TelefonoerrorProvider9.Clear();
               // TelefonoerrorProvider9.SetError(TelefonomaskedTextBox1, "Favor ingrese el numero telefono de su Recidencia");
                return false;
            }
            if (string.IsNullOrEmpty(CelularmaskedTextBox2.Text))
            {
               // CelularerrorProvider10.Clear();
               // CelularerrorProvider10.SetError(CelularmaskedTextBox2, "Favor ingrese el Numero de Celular");
                return false;
            }

            if (MasculinocheckBox.Checked == false && FemeninocheckBox.Checked == false)
            {
               // SexoerrorProvider1.SetError(SexogroupBox, "Seleccionar sexo");
                return false;
            }




            return true;
        }

        public void Limpiar()
        {
            DateTimePicker f = new DateTimePicker();
            EmpleadoIdtextBox.Clear();
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            CedulamaskedTextBox.Clear();
            DirecciontextBox.Clear();
            CiudadcomboBox.Text = "Elegir Su Ciudad";
            TelefonomaskedTextBox1.Clear();
            CelularmaskedTextBox2.Clear();
            FechaNacimientomaskedTextBox.Clear();
            MasculinocheckBox.Checked = false;
            FemeninocheckBox.Checked = false;
            FechadateTimePicker.Value = f.Value;
            //-----
            limpiarErroresProvider();

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id del Cliente que desea eliminar") && ValidarBuscar())
            {
                EmpleadosBLL.Eliminar(ut.StringInt(EmpleadoIdtextBox.Text));
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }

        }
        private void limpiarErroresProvider()
        {
            //NombreerrorProvider2.Clear();
            //ApellidoerrorProvider3.Clear();
           // CedulamaskedTextBox.Clear();
           // SexoerrorProvider1.Clear();
           // CiudaderrorProvider7.Clear();
           // DirrecionerrorProvider8.Clear();
           // TelefonoerrorProvider9.Clear();
           // CelularerrorProvider10.Clear();

        }
    }
}
