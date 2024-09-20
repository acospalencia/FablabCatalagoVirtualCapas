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
    /// Lógica de interacción para ModificarClubs.xaml
    /// </summary>
    public partial class ModificarClubs : MetroWindow
    {
        public ModificarClubs()
        {
            InitializeComponent();
        }
		public bool Validar()
		{
			return !string.IsNullOrEmpty(txtDetalle.Text) &&
				!string.IsNullOrEmpty(cbIdAutor.Text) &&
				!string.IsNullOrEmpty(cbIdClub.Text) &&
				!string.IsNullOrEmpty(dpFecha.Text);
		}
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
            var inscBL = new InscripcionClubBL();
            dgLista.ItemsSource = inscBL.RegresarLista();
        }

		private void dgLista_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var AutorBL = new AutoresBL();
			var ClubeBl = new ClubBL();

			cbIdAutor.ItemsSource = AutorBL.RegresarLista();
			cbIdAutor.DisplayMemberPath = "Nombres";
			cbIdAutor.SelectedValuePath = "Id";
			cbIdClub.ItemsSource = ClubeBl.RegresarLista();
			cbIdClub.DisplayMemberPath = "NombreClub";
			cbIdClub.SelectedValuePath = "Id";

            if (dgLista.SelectedItem != null)
            {
                var row = (InscripcionClub)dgLista.SelectedItem;
				
				txtId.Text = row.Id.ToString();
				cbIdAutor.SelectedValue = row.IdAutor;
				cbIdClub.SelectedValue = row.IdClub;
				txtDetalle.Text = row.Detalle;
				dpFecha.SelectedDate = row.FechaInscripcion;

				cbIdAutor.IsEnabled = true;
				cbIdClub.IsEnabled = true;
				txtDetalle.IsEnabled = true;
				dpFecha.IsEnabled = true;

				btnGuardar.Visibility = Visibility.Visible;
				btnEliminar.Visibility = Visibility.Visible;

			}
        }

		private void btnGuardar_Click(object sender, RoutedEventArgs e)
		{
			if (Validar())
			{
				var ModiInscripcion = new InscripcionClub
				{
					Id = Convert.ToInt32(txtId.Text),
					IdAutor = Convert.ToInt32(cbIdAutor.SelectedValue),
					IdClub = Convert.ToInt32(cbIdClub.SelectedValue),
					FechaInscripcion = dpFecha.SelectedDate.Value,
					Detalle = txtDetalle.Text,
				};

				var inscr = new InscripcionClubBL();
				inscr.ModiInscripcion(ModiInscripcion);
				dgLista.ItemsSource = null;
				dgLista.ItemsSource = inscr.RegresarLista();

				txtDetalle.Text = null;
				cbIdAutor.Text = null;
				cbIdClub.Text = null;
				dpFecha.Text = null;

				cbIdAutor.IsEnabled = false;
				cbIdClub.IsEnabled = false;
				txtDetalle.IsEnabled = false;
				dpFecha.IsEnabled = false;

				btnGuardar.Visibility = Visibility.Hidden;
				btnEliminar.Visibility = Visibility.Hidden;

				MessageBox.Show("Los datos se han modificado correctamente", "Correcto");

			}
			else
			{
				MessageBox.Show("Por favor rellenar los correspondientes textbox", "Error");
			}
		}

		private void btnEliminar_Click(object sender, RoutedEventArgs e)
		{
			MessageBoxResult result = MessageBox.Show("¡Seguro que desea eliminar el registro seleccionado!", "Alerta", MessageBoxButton.OKCancel, MessageBoxImage.Question);

			if (result == MessageBoxResult.OK)
			{
				var ModiInscripcion = new InscripcionClub
				{
					Id = Convert.ToInt32(txtId.Text),
					IdAutor = Convert.ToInt32(cbIdAutor.SelectedValue),
					IdClub = Convert.ToInt32(cbIdClub.SelectedValue),
					FechaInscripcion = dpFecha.SelectedDate.Value,
					Detalle = txtDetalle.Text,
				};

				var inscr = new InscripcionClubBL();
				inscr.DeleteInscripcion(ModiInscripcion);
				dgLista.ItemsSource = null;
				dgLista.ItemsSource = inscr.RegresarLista();

				txtDetalle.Text = null;
				cbIdAutor.Text = null;
				cbIdClub.Text = null;
				dpFecha.Text = null;

				cbIdAutor.IsEnabled = false;
				cbIdClub.IsEnabled = false;
				txtDetalle.IsEnabled = false;
				dpFecha.IsEnabled = false;

				btnGuardar.Visibility = Visibility.Hidden;
				btnEliminar.Visibility = Visibility.Hidden;

				MessageBox.Show("Los datos se han Eliminado correctamente", "Correcto");

			}

		}

		private void btn_regresar_Click(object sender, RoutedEventArgs e)
		{
			var ScBack = new MantenimientoClubs();
			ScBack.Show();
			this.Close();
		}

		private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (string.IsNullOrEmpty(txtBuscar.Text) || txtBuscar.Text == "0")
			{
				var regresarlista = new InscripcionClubBL();
				dgLista.ItemsSource = regresarlista.RegresarLista();
			}
			else
			{
				var Lista = new InscripcionClubBL();
				var textoBusqueda = txtBuscar.Text.ToLower();
				var usuariosFiltrados = Lista.RegresarLista().Where(p => p.Detalle.ToLower().Contains(textoBusqueda)).ToList();
				dgLista.ItemsSource = usuariosFiltrados;
			}
			if (!string.IsNullOrEmpty(txtBuscar.Text) && int.TryParse(txtBuscar.Text, out int idBuscada))
			{
				var Lista2 = new InscripcionClubBL();
				var prototiposFiltrados = Lista2.RegresarLista().Where(p => p.Id == idBuscada).ToList();
				dgLista.ItemsSource = prototiposFiltrados;
			}
		}
	}
}
