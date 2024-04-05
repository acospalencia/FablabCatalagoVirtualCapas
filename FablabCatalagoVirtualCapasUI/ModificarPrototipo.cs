﻿using FablabCatalagoVirtualCapasBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FablabCatalagoVirtualCapasUI
{
    public partial class ModificarPrototipo : Form
    {
        public ModificarPrototipo()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

		private void ModificarPrototipo_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

        private void ModificarPrototipo_Load(object sender, EventArgs e)
        {
			var regresarlista = new PrototipoBL();
			dgListado.DataSource = regresarlista.regresarlista();
        }

		private void btnRegresar_Click_1(object sender, EventArgs e)
		{
			var anteriorForm = new AgregarPrototipo();
			anteriorForm.Show();
			this.Hide();
		}

		private void txtbuscar_TextChanged(object sender, EventArgs e)
		{

		}
	}
}


