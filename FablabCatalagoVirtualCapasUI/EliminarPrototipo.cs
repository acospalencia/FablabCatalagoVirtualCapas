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
	public partial class EliminarPrototipo : Form
	{
		public EliminarPrototipo()
		{
			InitializeComponent();
		}
		//metodo para que al cargar el formulario se actualice el datagrid con la informacion dentro de el listado prototipos
		private void EliminarPrototipo_Load(object sender, EventArgs e)
		{
			var regresarLista = new PrototipoBL();
			dgVer.DataSource = regresarLista.regresarlista();
		}
		//metodo para que la aplicacion se cierre al darle a la x 
		private void EliminarPrototipo_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
		//metodo para mostrar el formulario anterior
		private void btnRegresar_Click(object sender, EventArgs e)
		{
			var anteriorForm = new AgregarPrototipo();
			anteriorForm.Show();
			this.Hide();
		}
		//metodo para que se mande la informacion de las celdas de la linea seleccionada en el datagrid
		private void dgVer_SelectionChanged(object sender, EventArgs e)
		{
			if (dgVer != null && dgVer.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dgVer.SelectedRows[0];
				if (row != null)
				{
					btnEliminar.Enabled = true;
					txtId.Text = row.Cells[0].Value.ToString();
				}
			}
		}
		//metodo del boton para eliminar el prototipo de la lista seleccionada del datagrid
		private void btnEliminar_Click(object sender, EventArgs e)
		{
			var borrarProto = new Prototipo
			{
				Id = int.Parse(txtId.Text)
			};
			if (borrarProto != null)
			{
				var eliminarProto = new PrototipoBL();
				eliminarProto.Eliminar(borrarProto);
				var actuaLista = new PrototipoBL();
				dgVer.DataSource = null;
				dgVer.DataSource = actuaLista.regresarlista();
				txtId.Text = null;
				btnEliminar.Enabled = false;
				MessageBox.Show("Los datos se han Eliminado con exito");
			}
		}
		//metodo para buscar un prototipo dentro de el datagrid por el ID
		private void txtbuscar_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtbuscar.Text) || txtbuscar.Text == "0")
			{
				var regresarlista = new PrototipoBL();
				dgVer.DataSource = regresarlista.regresarlista();
			}
			else
			{
				var Lista = new PrototipoBL();
				var textoBusqueda = txtbuscar.Text.ToLower();
				var usuariosFiltrados = Lista.regresarlista().Where(p => p.NombrePrototipo.ToLower().Contains(textoBusqueda)).ToList();
				dgVer.DataSource = usuariosFiltrados;
			}
			if (!string.IsNullOrEmpty(txtbuscar.Text) && int.TryParse(txtbuscar.Text, out int idBuscada))
			{
				var Lista2 = new PrototipoBL();
				var prototiposFiltrados = Lista2.regresarlista().Where(p => p.Id == idBuscada).ToList();
				dgVer.DataSource = prototiposFiltrados;
			}
		}
	}
}

