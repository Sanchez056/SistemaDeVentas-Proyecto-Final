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
    public partial class RegistrosGarantes : Form
    {
        public RegistrosGarantes()
        {
            InitializeComponent();
        }

        private void RegistrosGarantes_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TelefonoRecidencialtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        Utilidades ut = new Utilidades();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del Garantes que desea buscar") && ValidarBuscar())
                LLenar(GaranteBLL.Buscar(ut.StringInt(GaranteIdtextBox.Text)));
        }

        private void LLenar(Garantes garante)
        {
            GaranteIdtextBox.Text = garante.GaranteId.ToString();
            NombretextBox.Text = garante.Nombre;
            ApellidotextBox.Text = garante.Apellido;
            cedulaMaskedTextBox.Text = garante.Cedula;
            CiudadcomboBox.Text = garante.Ciudad;
            DirecciontextBox.Text = garante.Direccion;
            TelefonomaskedTextBox.Text = garante.Telefono;
            CeluarmaskedTextBox1.Text = garante.Celular;
            if (garante.Sexo == "M")
                MasculinocheckBox.Checked = true;
            if (garante.Sexo == "F")
                FemeninocheckBox.Checked = true;

        }
       
        private bool ValidarBuscar()
        {
            if (GaranteBLL.Buscar(ut.StringInt(GaranteIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(GaranteIdtextBox.Text))
            {

                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }


        private void NuevoBotton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            DateTimePicker f = new DateTimePicker();
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            cedulaMaskedTextBox.Clear();
            CiudadcomboBox.Text = "Elegir Su Ciudad";
            DirecciontextBox.Clear();
            TelefonomaskedTextBox.Clear();
            CeluarmaskedTextBox1.Clear();
            MasculinocheckBox.Checked = false;
            FemeninocheckBox.Checked = false;
            fechaDateTimePicker.Value = f.Value;

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Garantes garante = new Garantes();
            BuscarerrorProvider.Clear();
            LlenarClase(garante);
            if (ValidarTextbox() && ValidarExiste(cedulaMaskedTextBox.Text))
            {
                GaranteBLL.Insertar(garante);
                Limpiar();
                limpiarErroresProvider();
                MessageBox.Show("-_-Guardado Con Exito-_-");
            }

        }
        private bool ValidarExiste(string aux)
        {
            if (GaranteBLL.GetListaCedula(aux).Count() > 0)
            {
                MessageBox.Show("Este numero cedula  de Garante  ya existe, favor intentar con otro Garante ...");
                return false;
            }
            return true;
        }
        private void LlenarClase(Garantes g)
        {
            g.Nombre = NombretextBox.Text;
            g.Apellido = ApellidotextBox.Text;
            g.Cedula= cedulaMaskedTextBox.Text;
            g.Ciudad = CiudadcomboBox.Text;
            g.Direccion = DirecciontextBox.Text;
            g.Telefono = TelefonomaskedTextBox.Text;
            g.Celular = CeluarmaskedTextBox1.Text;
            if (MasculinocheckBox.Checked == true)
            {
                g.Sexo = "M";
            }
            else
            {
                if (FemeninocheckBox.Checked == true)

                    g.Sexo = "F";
                else

                    g.Sexo = "M";
            }

            g.Fecha = fechaDateTimePicker.Value;


        }


        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(NombretextBox.Text) &&
                string.IsNullOrEmpty(ApellidotextBox.Text) &&
                string.IsNullOrEmpty(cedulaMaskedTextBox.Text) &&
                string.IsNullOrEmpty(DirecciontextBox.Text) &&
                string.IsNullOrEmpty(TelefonomaskedTextBox.Text) &&
                string.IsNullOrEmpty(CeluarmaskedTextBox1.Text)
               
                )
            {
                NombreerrorProvider.SetError(NombretextBox, "Favor Ingresar el Nombre de Garante");
                ApellidoerrorProvider.SetError(ApellidotextBox, "Favor Ingresar el Apellido de Garante");
                CedulaerrorProvider.SetError(cedulaMaskedTextBox, "Favor Ingresar la Cedula Garante");
                CiudaderrorProvider.SetError(CiudadcomboBox, "Favor Ingresar la Ciudad actual de donde recide el Garante");
                DirrecionerrorProvider.SetError(DirecciontextBox, "Favor Ingresar la Dirrecion de la ciudad de donde esta el Garante");
                TelefonoerrorProvider.SetError(TelefonomaskedTextBox, "Favor Ingresar el Numero de Telefono Recidencia del Garante");
                CelularerrorProvider.SetError(CeluarmaskedTextBox1, "Favor Ingresarel Numero de Celular de Garante");

                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                NombreerrorProvider.Clear();
                NombreerrorProvider.SetError(NombretextBox, "Favor ingresar el Nombre del Garante");
                return false;
            }
            if (string.IsNullOrEmpty(ApellidotextBox.Text))
            {
                ApellidoerrorProvider.Clear();
                ApellidoerrorProvider.SetError(ApellidotextBox, "Favor ingresar el Apellido del Garante");
                return false;
            }

            if (string.IsNullOrEmpty(cedulaMaskedTextBox.Text))
            {
                CedulaerrorProvider.Clear();
                CedulaerrorProvider.SetError(cedulaMaskedTextBox, "Favor ingresar el Numero de Cedula de Garante");
                return false;
            }
            if (string.IsNullOrEmpty(CiudadcomboBox.Text))
            {
                CiudaderrorProvider.Clear();
                CiudaderrorProvider.SetError(CiudadcomboBox, "Favor ingrese la Ciudad que Actual del Garante");
                return false;
            }
            if (string.IsNullOrEmpty(DirecciontextBox.Text))
            {
                DirecciontextBox.Clear();
                DirrecionerrorProvider.SetError(DirecciontextBox, "Favor ingrese la dirrecion de la ciudad de donde vive el Garante");

                return false;
            }

            if (string.IsNullOrEmpty(TelefonomaskedTextBox.Text))
            {
                TelefonoerrorProvider.Clear();
                TelefonoerrorProvider.SetError(TelefonomaskedTextBox, "Favor ingrese el numero telefono  de la Recidencia del garante");
                return false;
            }

            if (string.IsNullOrEmpty(CeluarmaskedTextBox1.Text))
            {
                CelularerrorProvider.Clear();
                CelularerrorProvider.SetError(CeluarmaskedTextBox1, "Favor ingrese el Numero de Celular");
                return false;
            }
            if (MasculinocheckBox.Checked == false && FemeninocheckBox.Checked == false)
            {
                SexoerrorProvider.SetError(SexogroupBox, "Seleccionar sexo");
                return false;
            }


            return true;
        }


        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id del Garante que desea eliminar") && ValidarBuscar())
            {
                GaranteBLL.Eliminar(ut.StringInt(GaranteIdtextBox.Text));
                Limpiar();
                limpiarErroresProvider();
                MessageBox.Show("ELiminado con exito");
            }
        }
        private void limpiarErroresProvider()
        {
            NombreerrorProvider.Clear();
            ApellidoerrorProvider.Clear();
            CedulaerrorProvider.Clear();
            SexoerrorProvider.Clear();
            CiudaderrorProvider.Clear();
            DirrecionerrorProvider.Clear();
            TelefonoerrorProvider.Clear();
            CelularerrorProvider.Clear();

        }
    }
}
