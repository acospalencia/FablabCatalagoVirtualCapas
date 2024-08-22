using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasEN;
using interfaces;
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
using System.Windows.Shapes;

namespace prototipos
{
	/// <summary>
	/// Lógica de interacción para Window2.xaml
	/// </summary>
	public partial class Window2 : MetroWindow
	{
		public Window2()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			var regresarLista = new PrototipoBL();
			dgVer.ItemsSource = regresarLista.regresarlista();
		}

		private void btn_regresar_Click(object sender, RoutedEventArgs e)
		{
			var ScBack = new RegistrarPrototipos();
			ScBack.Show();
			this.Close();
		}

		private void dgVer_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (dgVer.SelectedItem != null)
			{
				var row = (Prototipo)dgVer.SelectedItem;
				if (row != null)
				{
					btnEliminar.Visibility = Visibility.Visible;
					txtId.Text = row.Id.ToString();
				}
			}
		}

		private void btnEliminar_Click(object sender, RoutedEventArgs e)
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
				dgVer.ItemsSource = null;
				dgVer.ItemsSource = actuaLista.regresarlista();
				txtId.Text = null;
				btnEliminar.Visibility = Visibility.Hidden;
				MessageBox.Show("Los datos se han Eliminado con exito");
			}
		}

		private void txtbuscar_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (string.IsNullOrEmpty(txtbuscar.Text) || txtbuscar.Text == "0")
			{
				var regresarlista = new PrototipoBL();
				dgVer.ItemsSource = regresarlista.regresarlista();
			}
			else
			{
				var Lista = new PrototipoBL();
				var textoBusqueda = txtbuscar.Text.ToLower();
				var usuariosFiltrados = Lista.regresarlista().Where(p => p.NombrePrototipo.ToLower().Contains(textoBusqueda)).ToList();
				dgVer.ItemsSource = usuariosFiltrados;
			}
			if (!string.IsNullOrEmpty(txtbuscar.Text) && int.TryParse(txtbuscar.Text, out int idBuscada))
			{
				var Lista2 = new PrototipoBL();
				var prototiposFiltrados = Lista2.regresarlista().Where(p => p.Id == idBuscada).ToList();
				dgVer.ItemsSource = prototiposFiltrados;
			}
		}
	}
}
