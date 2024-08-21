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

namespace UI
{
    /// <summary>
    /// Lógica de interacción para Eliminar_Proveedor.xaml
    /// </summary>
    public partial class Eliminar_Proveedor : MetroWindow
    {
        public Eliminar_Proveedor()
        {
            InitializeComponent();
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

		private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (string.IsNullOrEmpty(txtBuscar.Text) || txtBuscar.Text == "0")
			{
				var regresarlista = new ProveedorBL();
				dgVer.ItemsSource = regresarlista.RegresarLista();
			}
			else
			{
				var Lista = new ProveedorBL();
				var textoBusqueda = txtBuscar.Text.ToLower();
				var usuariosFiltrados = Lista.RegresarLista().Where(p => p.Nombres.ToLower().Contains(textoBusqueda)).ToList();
				dgVer.ItemsSource = usuariosFiltrados;
			}
			if (!string.IsNullOrEmpty(txtBuscar.Text) && int.TryParse(txtBuscar.Text, out int idBuscada))
			{
				var Lista2 = new ProveedorBL();
				var prototiposFiltrados = Lista2.RegresarLista().Where(p => p.Id == idBuscada).ToList();
				dgVer.ItemsSource = prototiposFiltrados;
			}
		}

		private void dgVer_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (dgVer.SelectedItem != null)
			{
				var row = (Proveedor)dgVer.SelectedItem;

				txtId.Text = row.Id.ToString();

				btnEliminar.Visibility = Visibility.Visible;
			}
		}

		private void btnEliminar_Click(object sender, RoutedEventArgs e)
		{
			var delProve = new Proveedor
			{
				Id = Convert.ToInt32(txtId.Text),
			};
			var proveBL = new ProveedorBL();
			proveBL.EliminarProveedor(delProve);
			dgVer.ItemsSource = null;
			dgVer.ItemsSource = proveBL.RegresarLista();

			btnEliminar.Visibility = Visibility.Hidden;

			MessageBox.Show("Los datos se han eliminado con exito", "Correcto");
		}
	}
}
