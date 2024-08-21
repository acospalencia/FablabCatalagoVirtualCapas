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
using System.Windows.Shapes;

namespace interfaces
{
    /// <summary>
    /// Lógica de interacción para ModificarAutores.xaml
    /// </summary>
    public partial class ModificarAutores : MetroWindow
    {
        public ModificarAutores()
        {
            InitializeComponent();
        }
		public bool Validar()
		{
			return !string.IsNullOrEmpty(txtNombres.Text) &&
				!string.IsNullOrEmpty(txtApellidos.Text) &&
				!string.IsNullOrEmpty(txtCorreoElectronico.Text) &&
				!string.IsNullOrEmpty(dtFecha.Text);
		}

		private void btn_regresar_Click(object sender, RoutedEventArgs e)
		{
			var ScBack = new MantenimientoAutores();
			ScBack.Show();
			this.Close();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			var autorBL = new AutoresBL();
			dgVer.ItemsSource = autorBL.RegresarLista();
		}

		private void dgVer_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (dgVer.SelectedItem != null)
			{
				var row = (Autores)dgVer.SelectedItem;

				txtId.IsEnabled = true;
				txtNombres.IsEnabled = true;
				txtApellidos.IsEnabled = true;
				txtCorreoElectronico.IsEnabled = true;
				dtFecha.IsEnabled = true;

				btnEliminar.Visibility = Visibility.Visible;
				btnGuardar.Visibility = Visibility.Visible;

				txtId.Text = row.Id.ToString();
				txtNombres.Text = row.Nombres;
				txtApellidos.Text = row.Apellidos;
				txtCorreoElectronico.Text = row.CorreElectronico;
				dtFecha.SelectedDate = row.FechaRegistro;
			}
		}

		private void btnGuardar_Click(object sender, RoutedEventArgs e)
		{
            if (Validar())
            {
				var ModiAutor = new Autores
				{
					Id = Convert.ToInt32(txtId.Text),
					Nombres = txtNombres.Text,
					Apellidos = txtApellidos.Text,
					CorreElectronico = txtCorreoElectronico.Text,
					FechaRegistro = dtFecha.SelectedDate.Value
				};

				var autorBL = new AutoresBL();
				autorBL.ModificarAutor(ModiAutor);
				dgVer.ItemsSource = null;
				dgVer.ItemsSource = autorBL.RegresarLista();

				txtNombres.Text = null;
				txtApellidos.Text = null;
				txtCorreoElectronico.Text = null;
				dtFecha.SelectedDate = null;

				btnEliminar.Visibility = Visibility.Hidden;
				btnGuardar.Visibility = Visibility.Hidden;

				MessageBox.Show("Los datos se han actualizado con exito","Correcto");
			}
            else
            {
				MessageBox.Show("Por favor llene los correspondientes textbox", "Error");
            }
        }

		private void btnEliminar_Click(object sender, RoutedEventArgs e)
		{
			MessageBoxResult result = MessageBox.Show("¡Seguro que desea eliminar el registro seleccionado!", "Alerta", MessageBoxButton.OKCancel, MessageBoxImage.Question);

			if (result == MessageBoxResult.OK)
			{
				var DeleteAutor = new Autores
				{
					Id = Convert.ToInt32(txtId.Text),
				};
				var autorBL = new AutoresBL();
				autorBL.EliminarAutor(DeleteAutor);
				dgVer.ItemsSource = null;
				dgVer.ItemsSource = autorBL.RegresarLista();

				txtNombres.Text = null;
				txtApellidos.Text = null;
				txtCorreoElectronico.Text = null;
				dtFecha.SelectedDate = null;

				btnEliminar.Visibility = Visibility.Hidden;
				btnGuardar.Visibility = Visibility.Hidden;

				MessageBox.Show("Los datos se han eliminado con exito", "Correcto");
			}
		}

		private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (string.IsNullOrEmpty(txtBuscar.Text) || txtBuscar.Text == "0")
			{
				var regresarlista = new AutoresBL();
				dgVer.ItemsSource = regresarlista.RegresarLista();
			}
			else
			{
				var Lista = new AutoresBL();
				var textoBusqueda = txtBuscar.Text.ToLower();
				var usuariosFiltrados = Lista.RegresarLista().Where(p => p.Nombres.ToLower().Contains(textoBusqueda)).ToList();
				dgVer.ItemsSource = usuariosFiltrados;
			}
			if (!string.IsNullOrEmpty(txtBuscar.Text) && int.TryParse(txtBuscar.Text, out int idBuscada))
			{
				var Lista2 = new AutoresBL();
				var prototiposFiltrados = Lista2.RegresarLista().Where(p => p.Id == idBuscada).ToList();
				dgVer.ItemsSource = prototiposFiltrados;
			}
		}
	}
}
