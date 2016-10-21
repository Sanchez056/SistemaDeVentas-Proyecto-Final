﻿using System;
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
using DAL;


namespace SistemaDeVentas
{
    public partial class RegistroDeClientes : Form
    {
        public RegistroDeClientes()
        {
            InitializeComponent();
        }

        private void Sexolabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistroDeClientes_Load(object sender, EventArgs e)
        {

        }
        private void LLenar(Clientes cliente)
        {
            
            ClienteIdtextBox.Text = cliente.ClienteId.ToString();
            NombretextBox.Text = cliente.Nombre;
            ApellidotextBox.Text = cliente.Apellido;
            CiudadcomboBox.Text = cliente.Ciudad;
            DirecciontextBox.Text = cliente.Direccion;
            CedulamaskedTextBox.Text = cliente.Cedula;
            TelefonomaskedTextBox1.Text = cliente.Telefono;
            CelularmaskedTextBox2.Text = cliente.Celular;
            if (cliente.Sexo == "M")
                MasculinocheckBox.Checked = true;
            if (cliente.Sexo == "F")
                FemeninocheckBox.Checked = true;

        }
        Utilidades ut = new Utilidades();
        private bool ValidarBuscar()
        {
            if (ClientesBLL.Buscar(ut.StringInt(ClienteIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(ClienteIdtextBox.Text))
            {

                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }

        //----------
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            BuscarerrorProvider1.Clear();
            LlenarClase(cliente);
            if (ValidarTextbox() && ValidarExiste(CedulamaskedTextBox.Text))
            {
                ClientesBLL.Insertar(cliente);
                Limpiar();
                MessageBox.Show("-_-Guardado Con Exito-_-");
            }


        }

        private bool ValidarExiste(string aux)
        {
            if (ClientesBLL.GetListaCedula(aux).Count() > 0)
            {
                MessageBox.Show("Este cedula de cliente ya existe, favor intentar con otra Cedula ...");
                return false;
            }
            return true;
        }
        private void LlenarClase(Clientes c)
        {
            CiudadClientes cud = new CiudadClientes();
            c.Nombre = NombretextBox.Text;
            c.Apellido = ApellidotextBox.Text;
            c.Cedula = CedulamaskedTextBox.Text;
            c.Ciudad = cud.CiudadCliente = CiudadcomboBox.Text;
            c.Direccion = DirecciontextBox.Text;
            c.Telefono = TelefonomaskedTextBox1.Text;
            c.Celular = CelularmaskedTextBox2.Text;
            if (MasculinocheckBox.Checked == true)
            {
                c.Sexo = "M";
            }
            else
            {
                if (FemeninocheckBox.Checked == true)

                    c.Sexo = "F";
                else

                    c.Sexo = "M";
            }

            c.Fecha = FechadateTimePicker.Value;


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
                 NombreerrorProvider2.SetError(NombretextBox, "Favor Ingresar el Nombre de cliente");
                 ApellidoerrorProvider3.SetError(ApellidotextBox, "Favor Ingresar el Apellido de Cliente");
                 CedulaerrorProvider4.SetError(CedulamaskedTextBox, "Favor Ingresar la Cedula Cliente");
                 CiudaderrorProvider7.SetError(CiudadcomboBox, "Favor Ingresar la Ciudad actual de donde recide el cliente");
                 DirrecionerrorProvider8.SetError(DirecciontextBox,"Favor Ingresar la Dirrecion de la ciudad de donde esta el Cliente");
                 TelefonoerrorProvider9.SetError(TelefonomaskedTextBox1, "Favor Ingresar el Numero de Telefono Recidencia del Cliente");
                 CedulaerrorProvider4.SetError(CedulamaskedTextBox, "Favor Ingresarel Numero de Celular de Cliente");
                 
                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                NombreerrorProvider2.Clear();
                NombreerrorProvider2.SetError(NombretextBox, "Favor ingresar el Nombre del Cliente");
                return false;
            }
            if (string.IsNullOrEmpty(ApellidotextBox.Text))
            {
                ApellidoerrorProvider3.Clear();
                ApellidoerrorProvider3.SetError(ApellidotextBox, "Favor ingresar el Apellido del Cliente");
                return false;
            }

            if (string.IsNullOrEmpty(CedulamaskedTextBox.Text))
            {
                 CedulaerrorProvider4.Clear();
                 CedulaerrorProvider4.SetError(CedulamaskedTextBox, "Favor ingresar el Numero de Cedula de Identidad");
                return false;
            }
            if (string.IsNullOrEmpty(CiudadcomboBox.Text))
            {
                CiudaderrorProvider7.Clear();
                CiudaderrorProvider7.SetError(CiudadcomboBox, "Favor ingrese la Ciudad que Actual de Cliente");
                return false;
            }
            if (string.IsNullOrEmpty(DirecciontextBox.Text))
            {
                DirecciontextBox.Clear();
                DirrecionerrorProvider8.SetError(DirecciontextBox, "Favor ingrese la dirrecion de la ciudad de donde vive cliente");
                return false;
            }

            if (string.IsNullOrEmpty(TelefonomaskedTextBox1.Text))
            {
                TelefonomaskedTextBox1.Clear();
                TelefonoerrorProvider9.SetError(TelefonomaskedTextBox1, "Favor ingrese el numero telefono de su Recidencia");
                return false;
            }
            if (string.IsNullOrEmpty(CelularmaskedTextBox2.Text))
            {
                CelularerrorProvider10.Clear();
                CelularerrorProvider10.SetError(CedulamaskedTextBox, "Favor ingrese el Numero de Celular");
                return false;
            }

            if (MasculinocheckBox.Checked == false && FemeninocheckBox.Checked == false)
            {
                SexoerrorProvider1.SetError(SexogroupBox, "Seleccionar sexo");
                return false;
            }




            return true;
        }




        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del Cliente que desea buscar") && ValidarBuscar())
                LLenar(ClientesBLL.Buscar(ut.StringInt(ClienteIdtextBox.Text)));
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            DateTimePicker f = new DateTimePicker();
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            CedulamaskedTextBox.Clear();
            DirecciontextBox.Clear();
            CiudadcomboBox.Text = "Elegir Su Ciudad";
            TelefonomaskedTextBox1.Clear();
            CelularmaskedTextBox2.Clear();
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
                ClientesBLL.Eliminar(ut.StringInt(ClienteIdtextBox.Text));
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }

        }

        public List<Clientes> lista = new List<Clientes>();
        private void CargarConboBox()
        {
            var db = new SistemaVentasDb();
            lista = db.Clientes.ToList();
            if (lista.Count > 0)
            {
                CiudadcomboBox.DataSource = lista;
                CiudadcomboBox.ValueMember = "ClienteId";
                CiudadcomboBox.DisplayMember = "Ciudad";
            }
        }
        ///---------------
        private void limpiarErroresProvider()
        {
            NombreerrorProvider2.Clear();
            ApellidoerrorProvider3.Clear();
            CedulamaskedTextBox.Clear();
            SexoerrorProvider1.Clear();
            CiudaderrorProvider7.Clear();
            DirrecionerrorProvider8.Clear();
            TelefonoerrorProvider9.Clear();
            CelularerrorProvider10.Clear();




        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            if (validarId("Favor Buscar al Cliente  que desea actualizar"))
            {
                LlenarClase(cliente);
                    ClientesBLL.Modificar(ut.StringInt(ClienteIdtextBox.Text), cliente);
                    Limpiar();
                    limpiarErroresProvider();
                    MessageBox.Show("Modificar con exito");
                

            }
        }

        ///-------------
    }
}
