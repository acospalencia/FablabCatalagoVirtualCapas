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
	public partial class AccionMaterial : Form
	{
		public AccionMaterial()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var forMatAgre = new AgregarMateriales();
			forMatAgre.Show();
			this.Hide();
		}

		private void AccionMaterial_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var forActuMateriales = new ActualizarMateriales();
			forActuMateriales.Show();
			this.Hide();
		}

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			this.Hide();
			var menuprincipal = new ElegirAccion();
			menuprincipal.Show();
		}
	}
}
