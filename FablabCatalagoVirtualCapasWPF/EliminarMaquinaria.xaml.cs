using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace interfaces
{
    /// <summary>
    /// Lógica de interacción para EliminarMaquinaria.xaml
    /// </summary>
    public partial class EliminarMaquinaria : Window
    {
        public EliminarMaquinaria()
        {
            InitializeComponent();
        }
		public bool Validar()
		{
			return !string.IsNullOrEmpty(txtNombre.Text) &&
				!string.IsNullOrEmpty(txtDetalle.Text) &&
				!string.IsNullOrEmpty(txtMarca.Text) &&
				!string.IsNullOrEmpty(cbIdEstado.Text);
		}

		private void btn_regresar_Click(object sender, RoutedEventArgs e)
		{
            var ScBack = new MantenimientoMaquinaria();
            ScBack.Show();
            this.Close();
        }

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			var maquiBL = new MaquinariaBL();
			dgVer.ItemsSource = maquiBL.MaquinariaList();
		}

		private void dgVer_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
            if (dgVer.SelectedItem != null)
            {
                var row = (Maquinaria)dgVer.SelectedItem;

				var estadosBL = new EstadosBL();
				cbIdEstado.ItemsSource = estadosBL.RegresarEstadosMaquinarias();
				cbIdEstado.DisplayMemberPath = "NombreEstado";
				cbIdEstado.SelectedValuePath = "Id";

				txtNombre.IsEnabled = true;
				txtMarca.IsEnabled = true;
				txtDetalle.IsEnabled = true;
				cbIdEstado.IsEnabled = true;

				txtId.Text = row.Id.ToString();
				txtNombre.Text = row.Nombre;
                txtMarca.Text = row.Marca;
                txtDetalle.Text = row.Detalle;
                cbIdEstado.SelectedValue = row.Idestado;

				btnGuardar.Visibility = Visibility.Visible;
				btnEliminar.Visibility = Visibility.Visible;
            }
        }

		private void btnGuardar_Click(object sender, RoutedEventArgs e)
		{
            if (Validar())
            {
				var ActuMaqui = new Maquinaria
				{
					Id = Convert.ToInt32(txtId.Text),
					Nombre = txtNombre.Text,
					Marca = txtMarca.Text,
					Detalle = txtDetalle.Text,
					Idestado = Convert.ToInt32(cbIdEstado.SelectedValue)
				};

				var modiMaqui = new MaquinariaBL();
				modiMaqui.ActualizarMaquinaria(ActuMaqui);
				dgVer.ItemsSource = null;
				dgVer.ItemsSource = modiMaqui.MaquinariaList();

				txtNombre.IsEnabled = false;
				txtMarca.IsEnabled = false;
				txtDetalle.IsEnabled = false;
				cbIdEstado.IsEnabled = false;

				txtId.Text = null;
				txtNombre.Text = null;
				txtMarca.Text = null;
				txtDetalle.Text = null;
				cbIdEstado.Text = null;

				btnGuardar.Visibility = Visibility.Hidden;
				btnEliminar.Visibility = Visibility.Hidden;

				MessageBox.Show("Los datos se han actualizado con exito","Correcto");
			}
            else
            {
				MessageBox.Show("Rellene los correspondientes textbox porfavor","Error");
            }
        }

		private void btnEliminar_Click(object sender, RoutedEventArgs e)
		{
			MessageBoxResult result = MessageBox.Show("¡Seguro que desea eliminar el registro seleccionado!", "Alerta", MessageBoxButton.OKCancel, MessageBoxImage.Question);

            if (result == MessageBoxResult.OK)
            {
				var DeleteMaqui = new Maquinaria
				{
					Id = Convert.ToInt32(txtId.Text),
				};

				var modiMaqui = new MaquinariaBL();
				modiMaqui.EliminarMaquinaria(DeleteMaqui);
				dgVer.ItemsSource = null;
				dgVer.ItemsSource = modiMaqui.MaquinariaList();

				txtNombre.IsEnabled = false;
				txtMarca.IsEnabled = false;
				txtDetalle.IsEnabled = false;
				cbIdEstado.IsEnabled = false;

				txtId.Text = null;
				txtNombre.Text = null;
				txtMarca.Text = null;
				txtDetalle.Text = null;
				cbIdEstado.Text = null;

				btnGuardar.Visibility = Visibility.Hidden;
				btnEliminar.Visibility = Visibility.Hidden;

				MessageBox.Show("Los datos se han eliminado con exito", "Correcto");
			}
            
		}

		private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (string.IsNullOrEmpty(txtbuscar.Text) || txtbuscar.Text == "0")
			{
				var regresarlista = new MaquinariaBL();
				dgVer.ItemsSource = regresarlista.MaquinariaList();
			}
			else
			{
				var Lista = new MaquinariaBL();
				var textoBusqueda = txtbuscar.Text.ToLower();
				var usuariosFiltrados = Lista.MaquinariaList().Where(p => p.Nombre.ToLower().Contains(textoBusqueda)).ToList();
				dgVer.ItemsSource = usuariosFiltrados;
			}
			if (!string.IsNullOrEmpty(txtbuscar.Text) && int.TryParse(txtbuscar.Text, out int idBuscada))
			{
				var Lista2 = new MaquinariaBL();
				var prototiposFiltrados = Lista2.MaquinariaList().Where(p => p.Id == idBuscada).ToList();
				dgVer.ItemsSource = prototiposFiltrados;
			}
		}
    }
	
}
