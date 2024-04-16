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
	public partial class AcercaNosotros : Form
	{
		public AcercaNosotros()
		{
			InitializeComponent();
		}

		private void AcercaNosotros_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			var formPrincipal = new PantallaPrincipal();
			formPrincipal.Show();
			this.Hide();
		}
	}
}
