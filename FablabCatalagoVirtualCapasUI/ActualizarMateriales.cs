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

        private void ActualizarMateriales_Load(object sender, EventArgs e)
        {

        }

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			this.Hide();
			var formRegresar = new AccionMaterial();
			formRegresar.Show();
		}

		private void ActualizarMateriales_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
