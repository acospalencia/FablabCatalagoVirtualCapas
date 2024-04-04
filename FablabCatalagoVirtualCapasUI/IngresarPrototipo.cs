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
	public partial class IngresarPrototipo : Form
	{
		public IngresarPrototipo()
		{
			InitializeComponent();
		}

		private void IngresarPrototipo_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			var formRegresar = new AgregarPrototipo();
			formRegresar.Show();
		}

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

	}
}
