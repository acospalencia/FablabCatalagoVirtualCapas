using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
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
		private bool validacion()
		{
			return !string.IsNullOrEmpty(txtNombre.Text) &&
					!string.IsNullOrEmpty(txtX.Text) &&
					!string.IsNullOrEmpty(txtY.Text) &&
					!string.IsNullOrEmpty(txtPrecio.Text) &&
					!string.IsNullOrEmpty(txtZ.Text);
		}

		private void ActualizarMateriales_Load(object sender, EventArgs e)
		{
			var Actualizardg = new MaterialesBL();
			dgMaterial.DataSource = null;
			dgMaterial.DataSource = Actualizardg.regresarLista();
			var tipo = new TipoMaterialBL();
			cbTipoMaterial.DataSource = tipo.regresarTipoMaterial();
			cbTipoMaterial.DisplayMember = "NombreTipo";
			cbTipoMaterial.ValueMember = "Id";
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

		private void dgMaterial_SelectionChanged(object sender, EventArgs e)
		{
			if (dgMaterial != null && dgMaterial.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dgMaterial.SelectedRows[0];
				if (row != null)
				{
					txtNombre.Enabled = true;
					txtX.Enabled = true;
					txtY.Enabled = true;
					txtZ.Enabled = true;
					txtPrecio.Enabled = true;
					cbTipoMaterial.Enabled = true;
					btnModificar.Visible = true;
					txtId.Text = row.Cells[0].Value.ToString();
					txtNombre.Text = row.Cells[1].Value.ToString();
					txtIdTipo.Text = row.Cells[2].Value.ToString();
					txtPrecio.Text = row.Cells[3].Value.ToString();
					txtX.Text = row.Cells[4].Value.ToString();
					txtY.Text = row.Cells[5].Value.ToString();
					txtZ.Text = row.Cells[6].Value.ToString();
				}
			}
		}

		private void btnLupa_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtbuscar.Text) || txtbuscar.Text == "0")
			{
				var regresarlista = new MaterialesBL();
				dgMaterial.DataSource = regresarlista.regresarLista();
			}
			else
			{
				var Lista = new MaterialesBL();
				var textoBusqueda = txtbuscar.Text.ToLower();
				var usuariosFiltrados = Lista.regresarLista().Where(p => p.NombreMaterial.ToLower().Contains(textoBusqueda)).ToList();
				dgMaterial.DataSource = usuariosFiltrados;
			}
			if (!string.IsNullOrEmpty(txtbuscar.Text) && int.TryParse(txtbuscar.Text, out int idBuscada))
			{
				var Lista2 = new PrototipoBL();
				var prototiposFiltrados = Lista2.regresarlista().Where(p => p.Id == idBuscada).ToList();
				dgMaterial.DataSource = prototiposFiltrados;
			}
		}

		private void btnModificar_Click_1(object sender, EventArgs e)
		{
			if (validacion())
			{
				var nuevomateria = new Materiales
				{
					Id = int.Parse(txtId.Text),
					NombreMaterial = txtNombre.Text,
					X = txtX.Text,
					Y = txtY.Text,
					Z = txtZ.Text,
					Precio = decimal.Parse(txtPrecio.Text),
					IdTipoMaterial = Convert.ToInt32(cbTipoMaterial.SelectedValue)
				};

				var guardar = new MaterialesBL();
				guardar.actualizarMateriales(nuevomateria);
				txtZ.Text = null;
				txtPrecio.Text = null;
				txtY.Text = null;
				txtX.Text = null;
				txtNombre.Text = null;
				MessageBox.Show("Los datos se han ingresado con exito");
				txtNombre.Enabled = false;
				txtX.Enabled = false;
				txtY.Enabled = false;
				txtZ.Enabled = false;
				txtPrecio.Enabled = false;
				cbTipoMaterial.Enabled = false;
				var Actualizardg = new MaterialesBL();
				dgMaterial.DataSource = null;
				dgMaterial.DataSource = Actualizardg.regresarLista();
			}
			else
			{
				MessageBox.Show("porfavor rellene los correspondientees textboxx");
			}

		}

		private void txtbuscar_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtbuscar.Text) || txtbuscar.Text == "0")
			{
				var regresarlista = new MaterialesBL();
				dgMaterial.DataSource = regresarlista.regresarLista();
			}
			else
			{
				var Lista = new MaterialesBL();
				var textoBusqueda = txtbuscar.Text.ToLower();
				var usuariosFiltrados = Lista.regresarLista().Where(p => p.NombreMaterial.ToLower().Contains(textoBusqueda)).ToList();
				dgMaterial.DataSource = usuariosFiltrados;
			}
			if (!string.IsNullOrEmpty(txtbuscar.Text) && int.TryParse(txtbuscar.Text, out int idBuscada))
			{
				var Lista2 = new PrototipoBL();
				var prototiposFiltrados = Lista2.regresarlista().Where(p => p.Id == idBuscada).ToList();
				dgMaterial.DataSource = prototiposFiltrados;
			}
		}

		private void txtIdTipo_TextChanged(object sender, EventArgs e)
		{
			if (int.TryParse(txtIdTipo.Text, out int idMaterial))
			{
				TipoMaterialBL MaquinariaBL = new TipoMaterialBL();
				TipoMaterial maquinaria = MaquinariaBL.MostrarPorIdTipo(idMaterial);
				if (maquinaria != null)
				{
					cbTipoMaterial.Text = maquinaria.NombreTipo;
				}
			}
		}
	}

}
