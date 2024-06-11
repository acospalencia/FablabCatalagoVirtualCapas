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
    public partial class EliminarRegistro : Form
    {
        public EliminarRegistro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			var anteriorForm = new ModificarRegistro();
			anteriorForm.Show();
			this.Hide();
		}
	}
}
