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
    public partial class InformacionPrototipos : Form
    {
        public InformacionPrototipos()
        {
            InitializeComponent();
		}
		//metodo para mostrar el formulario anterior
		private void btnRegresar_Click(object sender, EventArgs e)
		{
			var formRegresar = new ListaPrototipos();
			formRegresar.Show();
			this.Hide();
		}
		//metodo para que la aplicacion se cierre al darle a la x 
		private void InformacionPrototipos_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
