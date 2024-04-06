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

		private void InformacionPrototipos_Load(object sender, EventArgs e)
		{
		}

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			var formRegresar = new ListaPrototipos();
			formRegresar.Show();
			this.Hide();
		}

		private void InformacionPrototipos_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
