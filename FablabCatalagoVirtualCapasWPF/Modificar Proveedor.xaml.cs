using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasEN;
using MahApps.Metro.Controls;
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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace UI
{
	/// <summary>
	/// Lógica de interacción para Modificar_Proveedor.xaml
	/// </summary>
	public partial class Modificar_Proveedor : MetroWindow
	{
		public Modificar_Proveedor()
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

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			var proveBL = new ProveedorBL();
			dgVer.ItemsSource = proveBL.RegresarLista();
		}

		private void dgVer_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (dgVer.SelectedItem != null)
			{
				var row = (Proveedor)dgVer.SelectedItem;

				txtNombres.IsEnabled = true;
				txtApellidos.IsEnabled = true;
				txtTelefono.IsEnabled = true;
				txtDirección.IsEnabled = true;
				txtCorreo.IsEnabled = true;

				txtId.Text = row.Id.ToString();
				txtNombres.Text = row.Nombres;
				txtApellidos.Text = row.Apellidos;
				txtTelefono.Text = row.NumTelefono;
				txtDirección.Text = row.Direccion;
				txtCorreo.Text = row.CorreoElectronico;

				btnGuardar.Visibility = Visibility.Visible;
			}
		}

		private void btnGuardar_Click(object sender, RoutedEventArgs e)
		{
			if (Validar())
			{
				var modiProve = new Proveedor
				{
					Id = Convert.ToInt32(txtId.Text),
					Nombres = txtNombres.Text,
					Apellidos = txtApellidos.Text,
					Direccion = txtDirección.Text,
					NumTelefono = txtTelefono.Text,
					CorreoElectronico = txtCorreo.Text
				};

				var proveBL = new ProveedorBL();
				proveBL.ActualizarProveedores(modiProve);
				dgVer.ItemsSource = null;
				dgVer.ItemsSource = proveBL.RegresarLista();

				txtNombres.IsEnabled = false;
				txtApellidos.IsEnabled = false;
				txtTelefono.IsEnabled = false;
				txtDirección.IsEnabled = false;
				txtCorreo.IsEnabled = false;

				txtId.Text = null;
				txtNombres.Text = null;
				txtApellidos.Text = null;
				txtTelefono.Text = null;
				txtDirección.Text = null;
				txtCorreo.Text = null;

				btnGuardar.Visibility = Visibility.Hidden;

				MessageBox.Show("Los datos se han actualizado con exito","Correcto");
			}
			else
			{
				MessageBox.Show("Por favor rellene los correspondientes textbox", "Error");
			}
		}

		private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (string.IsNullOrEmpty(txtbuscar.Text) || txtbuscar.Text == "0")
			{
				var regresarlista = new ProveedorBL();
				dgVer.ItemsSource = regresarlista.RegresarLista();
			}
			else
			{
				var Lista = new ProveedorBL();
				var textoBusqueda = txtbuscar.Text.ToLower();
				var usuariosFiltrados = Lista.RegresarLista().Where(p => p.Nombres.ToLower().Contains(textoBusqueda)).ToList();
				dgVer.ItemsSource = usuariosFiltrados;
			}
			if (!string.IsNullOrEmpty(txtbuscar.Text) && int.TryParse(txtbuscar.Text, out int idBuscada))
			{
				var Lista2 = new ProveedorBL();
				var prototiposFiltrados = Lista2.RegresarLista().Where(p => p.Id == idBuscada).ToList();
				dgVer.ItemsSource = prototiposFiltrados;
			}
		}
	}
}
