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
					!string.IsNullOrEmpty(txtTipo.Text) &&
					!string.IsNullOrEmpty(txtAncho.Text) &&
					!string.IsNullOrEmpty(txtAlto.Text) &&
					!string.IsNullOrEmpty(txtPrecio.Text) &&
					!string.IsNullOrEmpty(txtProveedor.Text);
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
			
		}

		private void dgMaterial_SelectionChanged(object sender, EventArgs e)
		{
			
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
            if (validacion())
            {
				var nuevomateria = new Materiales
				{
					//NombreMaterial = txtNombre.Text,
					//Precio = double.Parse(txtPrecio.Text),
					//Z = txtProveedor.Text,
					//IdTipoMaterial = txtTipo.Text,
					//X = double.Parse(txtAncho.Text),
					//Y = double.Parse(txtAlto.Text),
				};

				var guardar = new MaterialesBL();
				guardar.guardarMaterial(nuevomateria);
				txtProveedor.Text = null;
				txtPrecio.Text = null;
				txtAlto.Text = null;
				txtAncho.Text = null;
				txtTipo.Text = null;
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
