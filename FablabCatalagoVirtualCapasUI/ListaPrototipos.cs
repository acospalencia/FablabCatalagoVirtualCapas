using FablabCatalagoVirtualCapasBL;
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
    public partial class ListaPrototipos : Form
    {
        public ListaPrototipos()
        {
            InitializeComponent();
        }

		private void ListaPrototipos_FormClosing(object sender, FormClosingEventArgs e)
		{
            Application.Exit();
		}

		private void btncancelar_Click_1(object sender, EventArgs e)
		{
			var formregresar = new PantallaPrincipal();
			formregresar.Show();
			this.Hide();
		}

		private void ListaPrototipos_Load(object sender, EventArgs e)
		{
			var regresarLista = new PrototipoBL();
			dgvlistaprototipos.DataSource = regresarLista.regresarlista();
		}
	}
}
