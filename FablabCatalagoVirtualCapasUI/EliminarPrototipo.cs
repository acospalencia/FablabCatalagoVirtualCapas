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
    public partial class EliminarPrototipo : Form
    {
        public EliminarPrototipo()
        {
            InitializeComponent();
        }

        private void EliminarPrototipo_Load(object sender, EventArgs e)
        {

        }

		private void txtBuscar_TextChanged(object sender, EventArgs e)
		{

		}

		private void EliminarPrototipo_FormClosing(object sender, FormClosingEventArgs e)
		{
            Application.Exit();
		}

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			var anteriorForm = new AgregarPrototipo();
			anteriorForm.Show();
			this.Hide();
		}
	}
}
