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

namespace SistemaDeVentas.Consultas
{
    public partial class ConsultaUsuarios : Form
    {
        public ConsultaUsuarios()
        {
            InitializeComponent();
        }

        Utilidades ut = new Utilidades();
        public List<Usuarios> lista = new List<Usuarios>();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(FiltrotextBox.Text))
            {

                lista = BLL.UsuariosBLL.GetLista(ut.StringInt(FiltrotextBox.Text));
            }
            else
            {
                lista = BLL.UsuariosBLL.GetLista();
            }

            ConsultaUsuariosdataGridView.DataSource = lista;
        }
    }
}
