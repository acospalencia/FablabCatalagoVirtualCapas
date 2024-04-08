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
    public partial class AgregarMateriales : Form
    {
        public AgregarMateriales()
        {
            InitializeComponent();
        }
		//metodo para mostrar el formulario anterior
		private void btnRegresar_Click(object sender, EventArgs e)
		{
			this.Hide();
			var formRegresar = new AccionMaterial();
			formRegresar.Show();
		}
		//metodo para que la aplicacion se cierre al darle a la x 
		private void AgregarMateriales_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
		//metodo para agregar un nuevo material a la lista de materiales
		private void btnGuardar_Click(object sender, EventArgs e)
		{

		}
	}
}
