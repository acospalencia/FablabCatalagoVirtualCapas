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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace UI
{
    /// <summary>
    /// Lógica de interacción para Eliminar_Material.xaml
    /// </summary>
    public partial class Eliminar_Material : Window
    {
        public Eliminar_Material()
        {
            InitializeComponent();
        }

		private void Window_Loaded(object sender, EventArgs e)
		{
			var regresarLista = new MaterialesBL();
			dgVer.ItemsSource = regresarLista.regresarLista();
		}

		private void btnRegresar1_Click(object sender, RoutedEventArgs e)
		{
            var ScBack = new Accion_Material();
            ScBack.Show();
            this.Close();
        }

		private void dgVer_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (dgVer.SelectedItem != null)
			{
				var row = (Materiales)dgVer.SelectedItem;

				if (row != null)
				{
					btnEliminar.Visibility = Visibility.Visible; 
					txtId.Text = row.Id.ToString(); 
				}
			}
		}

		private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (string.IsNullOrEmpty(txtbuscar.Text) || txtbuscar.Text == "0")
			{
				var regresarlista = new MaterialesBL();
				dgVer.ItemsSource = regresarlista.regresarLista();
			}
			else
			{
				var Lista = new MaterialesBL();
				var textoBusqueda = txtbuscar.Text.ToLower();
				var usuariosFiltrados = Lista.regresarLista().Where(p => p.NombreMaterial.ToLower().Contains(textoBusqueda)).ToList();
				dgVer.ItemsSource = usuariosFiltrados;
			}
			if (!string.IsNullOrEmpty(txtbuscar.Text) && int.TryParse(txtbuscar.Text, out int idBuscada))
			{
				var Lista2 = new MaterialesBL();
				var prototiposFiltrados = Lista2.regresarLista().Where(p => p.Id == idBuscada).ToList();
				dgVer.ItemsSource = prototiposFiltrados;
			}
		}

		private void btnBuscar_Click(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrEmpty(txtbuscar.Text) || txtbuscar.Text == "0")
			{
				var regresarlista = new MaterialesBL();
				dgVer.ItemsSource = regresarlista.regresarLista();
			}
			else
			{
				var Lista = new MaterialesBL();
				var textoBusqueda = txtbuscar.Text.ToLower();
				var usuariosFiltrados = Lista.regresarLista().Where(p => p.NombreMaterial.ToLower().Contains(textoBusqueda)).ToList();
				dgVer.ItemsSource = usuariosFiltrados;
			}
			if (!string.IsNullOrEmpty(txtbuscar.Text) && int.TryParse(txtbuscar.Text, out int idBuscada))
			{
				var Lista2 = new MaterialesBL();
				var prototiposFiltrados = Lista2.regresarLista().Where(p => p.Id == idBuscada).ToList();
				dgVer.ItemsSource = prototiposFiltrados;
			}
		}

		private void btnEliminar_Click(object sender, RoutedEventArgs e)
		{
			var borrarMat = new Materiales
			{
				Id = int.Parse(txtId.Text)
			};
			if (borrarMat != null)
			{
				var eliminarMat = new MaterialesBL();
				eliminarMat.eliminarMaterial(borrarMat);
				var actuaLista = new MaterialesBL();
				dgVer.ItemsSource = null;
				dgVer.ItemsSource = actuaLista.regresarLista();
				txtId.Text = null;
				btnEliminar.Visibility = Visibility.Hidden;
				MessageBox.Show("Los datos se han Eliminado con exito");
			}
		}
	}
}
