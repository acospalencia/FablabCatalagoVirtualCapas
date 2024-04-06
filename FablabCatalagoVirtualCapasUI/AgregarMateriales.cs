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

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			this.Hide();
			var formRegresar = new AccionMaterial();
			formRegresar.Show();
		}

		private void AgregarMateriales_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
