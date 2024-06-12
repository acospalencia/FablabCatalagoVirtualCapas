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
	public partial class AgregarMateriales : Form
	{
		public AgregarMateriales()
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

		private void AgregarMateriales_Load(object sender, EventArgs e)
		{
			var tipo = new TipoMaterialBL();
			cbTipoMaterial.DataSource = tipo.regresarTipoMaterial();
			cbTipoMaterial.DisplayMember = "NombreTipo";
			cbTipoMaterial.ValueMember = "Id";
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
            if (validacion())
            {
				var nuevomateria = new Materiales
				{
					NombreMaterial = txtNombre.Text,
					X = txtX.Text,
					Y = txtY.Text,
					Z = txtZ.Text,
					Precio = decimal.Parse(txtPrecio.Text),
					IdTipoMaterial = Convert.ToInt32(cbTipoMaterial.SelectedValue)
				};

				var guardar = new MaterialesBL();
				guardar.guardarMaterial(nuevomateria);
				txtZ.Text = null;
				txtPrecio.Text = null;
				txtY.Text = null;
				txtX.Text = null;
				txtNombre.Text = null;
				MessageBox.Show("Los datos se han ingresado con exito");
			}
			else
			{
				MessageBox.Show("porfavor rellene los correspondientees textboxx");
			}
			
		}

	}
}
