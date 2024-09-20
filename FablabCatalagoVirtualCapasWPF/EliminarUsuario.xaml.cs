using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasEN;
using FablabCatalagoVirtualCapasWPF;
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
	/// Lógica de interacción para Window5.xaml
	/// </summary>
	public partial class Window5 : MetroWindow 
	{
		public Window5()
		{
			InitializeComponent();
		}

		private void btn_regresar_Click(object sender, RoutedEventArgs e)
		{
			var ScBack = new AccionUsuarios();
			ScBack.Show();
			this.Close();
        }

		private void btnEliminar_Click(object sender, RoutedEventArgs e)
		{
			var eiminar = new User
			{
				Id = int.Parse(txtId.Text),
			};
			UserBL user = new UserBL();
			user.EliminarUsuario(eiminar);
			UserBL userBL = new UserBL();
			dglistado.ItemsSource = null;
			dglistado.ItemsSource = userBL.regresarLista();
			txtId.Text = null;
			btnEliminar.Visibility = Visibility.Hidden;
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			UserBL userBL = new UserBL();
			dglistado.ItemsSource = userBL.regresarLista();
		}

		private void txtbuscar_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (string.IsNullOrEmpty(txtbuscar.Text) || txtbuscar.Text == "0")
			{
				var regresarlista = new UserBL();
				dglistado.ItemsSource = regresarlista.regresarLista();
			}
			else
			{
				var Lista = new UserBL();
				var textoBusqueda = txtbuscar.Text.ToLower();
				var usuariosFiltrados = Lista.regresarLista().Where(p => p.Usuario.ToLower().Contains(textoBusqueda)).ToList();
				dglistado.ItemsSource = usuariosFiltrados;
			}
		}

		private void dglistado_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (dglistado.SelectedItem != null)
			{
				var row = (User)dglistado.SelectedItem;
				if (row != null)
				{
					btnEliminar.Visibility = Visibility.Visible;
					txtId.Text = row.Id.ToString();
				}
			}
		}
	}
}
