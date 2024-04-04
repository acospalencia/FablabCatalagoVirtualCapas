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
    public partial class ListaPrototipos : Form
    {
        public ListaPrototipos()
        {
            InitializeComponent();
        }

		private void btncancelar_Click(object sender, EventArgs e)
		{
            this.Hide();
            var formRegresar = new PantallaPrincipal();
            formRegresar.Show();

		}

		private void ListaPrototipos_FormClosing(object sender, FormClosingEventArgs e)
		{
            Application.Exit();
		}
	}
}
