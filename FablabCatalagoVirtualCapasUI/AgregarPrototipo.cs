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
    public partial class AgregarPrototipo : Form
    {
        public AgregarPrototipo()
        {
            InitializeComponent();
        }

		private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

		private void btnModificar_Click(object sender, EventArgs e)
		{
            this.Hide();
            var formModified = new ModificarPrototipo();
            formModified.Show();
		}


		private void btnRegresar_Click(object sender, EventArgs e)
		{
            this.Hide();
            var menuprincipal = new PantallaPrincipal();
            menuprincipal.Show();


		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
            var formEliminar = new EliminarPrototipo();
            formEliminar.Show();
            this.Hide();
		}

		private void btnIngresar_Click(object sender, EventArgs e)
		{
            var formIngresar = new IngresarPrototipo();
            formIngresar.Show();
            this.Hide();
		}
	}
}
