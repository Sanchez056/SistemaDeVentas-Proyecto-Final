﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas.Consultas
{
    public partial class MyViewerClientes : Form
    {
        public MyViewerClientes()
        {
            InitializeComponent();
        }

        private void MyViewerClientes_Load(object sender, EventArgs e)
        {

            this.ClientesreportViewer.RefreshReport();
        }
    }
}
