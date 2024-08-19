using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UI
{
	/// <summary>
	/// Lógica de interacción para Agregar_Proveedor.xaml
	/// </summary>
	public partial class Agregar_Proveedor : Window
	{
		public Agregar_Proveedor()
		{
			InitializeComponent();
		}

		public bool Validar()
		{
			return !string.IsNullOrEmpty(txtNombres.Text) &&
				!string.IsNullOrEmpty(txtApellidos.Text) &&
				!string.IsNullOrEmpty(txtDirección.Text) &&
				!string.IsNullOrEmpty(txtTelefono.Text) &&
				!string.IsNullOrEmpty(txtCorreo.Text);
		}

		private void btnRegresar_Click(object sender, RoutedEventArgs e)
		{
			var ScBack = new Registrar_Proveedor();
			ScBack.Show();
			this.Close();
		}

		private void btnGuardar_Click(object sender, RoutedEventArgs e)
		{
			if (Validar())
			{
				var AggProveedor = new Proveedor
				{
					Nombres = txtNombres.Text,
					Apellidos = txtApellidos.Text,
					Direccion = txtDirección.Text,
					NumTelefono = txtTelefono.Text,
					CorreoElectronico = txtCorreo.Text
				};

				var provedorBL = new ProveedorBL();
				provedorBL.GuardarProveedor(AggProveedor);

				txtNombres.Text = null;
				txtApellidos.Text = null;
				txtDirección.Text = null;
				txtTelefono.Text = null;
				txtCorreo.Text = null;

				MessageBox.Show("Los datos se han ingresado correctamente","Correcto");
			}
			else
			{
				MessageBox.Show("Por favor rellenos los correspondientes textbox", "Error");
			}
		}
	}
}
