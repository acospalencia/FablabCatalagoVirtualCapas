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
    public partial class ActualizarMateriales : Form
    {
        public ActualizarMateriales()
        {
            InitializeComponent();

		}
		//metodo para que al cargar el formulario se actulice el datagrid
        private void ActualizarMateriales_Load(object sender, EventArgs e)
        {

        }
		//metodo para mostrar el formulario anterior
		private void btnRegresar_Click(object sender, EventArgs e)
		{
			this.Hide();
			var formRegresar = new AccionMaterial();
			formRegresar.Show();
		}
		//metodo para que la aplicacion se cierre al darle a la x 
		private void ActualizarMateriales_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
		//metodo para modificar el material seleccionado anteriormente en el datagrid
		private void btnGuardar_Click(object sender, EventArgs e)
		{

		}
	}
}
