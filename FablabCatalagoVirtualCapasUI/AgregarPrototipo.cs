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
		//metodo para que la aplicacion se cierre al darle a la x 
		private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
		//metodo para mostrar el siguiente formulario
		private void btnModificar_Click(object sender, EventArgs e)
		{
            this.Hide();
            var formModified = new ModificarPrototipo();
            formModified.Show();
		}

		//metodo para mostrar el formulario anterior
		private void btnRegresar_Click(object sender, EventArgs e)
		{
            this.Hide();
            var menuprincipal = new ElegirAccion();
            menuprincipal.Show();
		}

		//metodo para mostrar el siguiente formulario
		private void btnEliminar_Click(object sender, EventArgs e)
		{
            var formEliminar = new EliminarPrototipo();
            formEliminar.Show();
            this.Hide();

		}
		//metodo para mostrar el siguiente formulario
		private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var formIngresarPrototipo = new IngresarPrototipo();
            formIngresarPrototipo.Show();
        }
    }
}
