using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasEN;
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
			var eiminar = new User
			{
				Id = int.Parse(txtId.Text),
			};
			UserBL user = new UserBL();
			user.EliminarUsuario(eiminar);
			UserBL userBL = new UserBL(); 
			dglistado.DataSource = null;
			dglistado.DataSource = userBL.regresarLista();
			txtId.Text = null;
			btnEliminar.Enabled = false;
		}

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			var anteriorForm = new ModificarRegistro();
			anteriorForm.Show();
			this.Hide();
		}

		private void EliminarRegistro_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void EliminarRegistro_Load(object sender, EventArgs e)
		{
			UserBL userBL = new UserBL();
			dglistado.DataSource = userBL.regresarLista();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtbuscar.Text) || txtbuscar.Text == "0")
			{
				var regresarlista = new UserBL();
				dglistado.DataSource = regresarlista.regresarLista();
			}
			else
			{
				var Lista = new UserBL();
				var textoBusqueda = txtbuscar.Text.ToLower();
				var usuariosFiltrados = Lista.regresarLista().Where(p => p.Usuario.ToLower().Contains(textoBusqueda)).ToList();
				dglistado.DataSource = usuariosFiltrados;
			}

		}

		private void dglistado_SelectionChanged(object sender, EventArgs e)
		{
			if (dglistado != null && dglistado.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dglistado.SelectedRows[0];
				if (row != null)
				{
					btnEliminar.Enabled = true;
					txtId.Text = row.Cells[0].Value.ToString();
				}
			}
		}
	}
}
