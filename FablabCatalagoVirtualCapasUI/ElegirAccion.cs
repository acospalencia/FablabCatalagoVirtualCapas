﻿using System;
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
	public partial class ElegirAccion : Form
	{
		public ElegirAccion()
		{
			InitializeComponent();
		}

		private void ElegirAccion_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var formMateriales = new AccionMaterial();
			formMateriales.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var formAgregarProto = new AgregarPrototipo();
			formAgregarProto.Show();
			this.Hide();
		}

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			this.Hide();
			var menuprincipal = new PantallaPrincipal();
			menuprincipal.Show();
		}
	}
}