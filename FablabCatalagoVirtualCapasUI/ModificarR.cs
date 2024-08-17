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
    public partial class ModificarR : Form
    {
        public ModificarR()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			var anteriorForm = new ModificarRegistro();
			anteriorForm.Show();
			this.Hide();
		}

		private void ModificarR_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{

		}
	}
}
