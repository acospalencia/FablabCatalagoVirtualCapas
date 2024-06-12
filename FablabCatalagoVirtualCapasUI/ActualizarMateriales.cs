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
			return !string.IsNullOrEmpty(txtNombre.Text);
					//!string.IsNullOrEmpty(txtTipo.Text) &&
					//!string.IsNullOrEmpty(txtAncho.Text) &&
					//!string.IsNullOrEmpty(txtAlto.Text) &&
					//!string.IsNullOrEmpty(txtPrecio.Text) &&
					//!string.IsNullOrEmpty(txtProveedor.Text);
		}

        private void ActualizarMateriales_Load(object sender, EventArgs e)
        {
			var Actualizardg = new MaterialesBL();
			dgMaterial.DataSource = null;
			dgMaterial.DataSource = Actualizardg.regresarLista();
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
					//btnModificar.Visible = true;
					//txtId.Text = row.Cells[0].Value.ToString();
					//txtNombre.Text = row.Cells[1].Value.ToString();
					//txtPrecio.Text = row.Cells[3].Value.ToString();
					//txtProveedor.Text = row.Cells[6].Value.ToString();
					//txtAlto.Text = row.Cells[5].Value.ToString();
					//txtAncho.Text = row.Cells[4].Value.ToString();
					//txtTipo.Text = row.Cells[2].Value.ToString();
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
			if(validacion())

			{
				var actualizar = new Materiales
				{
					//Id = int.Parse(txtId.Text),
					//NombreMaterial = txtNombre.Text,
					//Precio = double.Parse(txtPrecio.Text),
					//Z = txtProveedor.Text,
					//IdTipoMaterial = txtTipo.Text,
					//X = double.Parse(txtAncho.Text),
					//Y = double.Parse(txtAlto.Text),

				};
				if (actualizar != null)
				{
					var ActuDatos = new MaterialesBL();
					ActuDatos.actualizarMateriales(actualizar);
					var regresar = new MaterialesBL();
					dgMaterial.DataSource = null;
					dgMaterial.DataSource = regresar.regresarLista();
				}
				//txtProveedor.Text = null;
				//txtPrecio.Text = null;
				//txtAlto.Text = null;
				//txtAncho.Text = null;
				//txtTipo.Text = null;
				txtNombre.Text = null;
				btnModificar.Visible = false;
				MessageBox.Show("Los datos se han Actualizado con exito");
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
	}
	
}
