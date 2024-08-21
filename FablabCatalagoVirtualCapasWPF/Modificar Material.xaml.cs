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
    /// Lógica de interacción para Modificar_Material.xaml
    /// </summary>
    public partial class Modificar_Material : Window
    {
        public Modificar_Material()
        {
            InitializeComponent();
        }
		private bool validacion()
		{
			return !string.IsNullOrEmpty(txtNombre.Text) &&
					!string.IsNullOrEmpty(txtX.Text) &&
					!string.IsNullOrEmpty(txtY.Text) &&
					!string.IsNullOrEmpty(txtPrecio.Text) &&
					!string.IsNullOrEmpty(txtZ.Text);
		}

		private void btn_regresar_Click(object sender, RoutedEventArgs e)
		{
			var ScBack = new Accion_Material();
			ScBack.Show();
			this.Close();
		}

		private void btnBuscar_Click(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrEmpty(txtbuscar.Text) || txtbuscar.Text == "0")
			{
				var regresarlista = new MaterialesBL();
				dgMaterial.ItemsSource = regresarlista.regresarLista();
			}
			else
			{
				var Lista = new MaterialesBL();
				var textoBusqueda = txtbuscar.Text.ToLower();
				var usuariosFiltrados = Lista.regresarLista().Where(p => p.NombreMaterial.ToLower().Contains(textoBusqueda)).ToList();
				dgMaterial.ItemsSource = usuariosFiltrados;
			}
			if (!string.IsNullOrEmpty(txtbuscar.Text) && int.TryParse(txtbuscar.Text, out int idBuscada))
			{
				var Lista2 = new MaterialesBL();
				var prototiposFiltrados = Lista2.regresarLista().Where(p => p.Id == idBuscada).ToList();
				dgMaterial.ItemsSource = prototiposFiltrados;
			}
		}

		private void txtbuscar_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (string.IsNullOrEmpty(txtbuscar.Text) || txtbuscar.Text == "0")
			{
				var regresarlista = new MaterialesBL();
				dgMaterial.ItemsSource = regresarlista.regresarLista();
			}
			else
			{
				var Lista = new MaterialesBL();
				var textoBusqueda = txtbuscar.Text.ToLower();
				var usuariosFiltrados = Lista.regresarLista().Where(p => p.NombreMaterial.ToLower().Contains(textoBusqueda)).ToList();
				dgMaterial.ItemsSource = usuariosFiltrados;
			}
			if (!string.IsNullOrEmpty(txtbuscar.Text) && int.TryParse(txtbuscar.Text, out int idBuscada))
			{
				var Lista2 = new MaterialesBL();
				var prototiposFiltrados = Lista2.regresarLista().Where(p => p.Id == idBuscada).ToList();
				dgMaterial.ItemsSource = prototiposFiltrados;
			}
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			var Actualizardg = new MaterialesBL();
			dgMaterial.ItemsSource = null;
			dgMaterial.ItemsSource = Actualizardg.regresarLista();
			var tipo = new TipoMaterialBL();
			cbTipoMaterial.ItemsSource = tipo.regresarTipoMaterial();
			cbTipoMaterial.DisplayMemberPath = "NombreTipo";
			cbTipoMaterial.SelectedValuePath = "Id";
		}

		private void btnGuardar_Click(object sender, RoutedEventArgs e)
		{
			if (validacion())
			{
				var nuevomateria = new Materiales
				{
					Id = int.Parse(txtId.Text),
					NombreMaterial = txtNombre.Text,
					X = txtX.Text,
					Y = txtY.Text,
					Z = txtZ.Text,
					Precio = decimal.Parse(txtPrecio.Text),
					IdTipoMaterial = Convert.ToInt32(cbTipoMaterial.SelectedValue)
				};

				var guardar = new MaterialesBL();
				guardar.actualizarMateriales(nuevomateria);
				txtZ.Text = null;
				txtPrecio.Text = null;
				txtY.Text = null;
				txtX.Text = null;
				txtNombre.Text = null;
				MessageBox.Show("Los datos se han ingresado con exito");
				txtNombre.IsEnabled = false;
				txtX.IsEnabled = false;
				txtY.IsEnabled = false;
				txtZ.IsEnabled = false;
				txtPrecio.IsEnabled = false;
				cbTipoMaterial.IsEnabled = false;
				var Actualizardg = new MaterialesBL();
				dgMaterial.ItemsSource = null;
				dgMaterial.ItemsSource = Actualizardg.regresarLista();
			}
			else
			{
				MessageBox.Show("porfavor rellene los correspondientees textboxx");
			}
		}

		private void dgMaterial_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (dgMaterial.SelectedItem != null)
			{
				var row = (Materiales)dgMaterial.SelectedItem;
				if (row != null)
				{
					txtNombre.IsEnabled = true;
					txtX.IsEnabled = true;
					txtY.IsEnabled = true;
					txtZ.IsEnabled = true;
					txtPrecio.IsEnabled = true;
					cbTipoMaterial.IsEnabled = true;

					btnModificar.Visibility = Visibility.Visible;
					
					txtId.Text = row.Id.ToString();
					txtNombre.Text = row.NombreMaterial;
					txtIdTipo.Text = row.IdTipoMaterial.ToString();
					txtPrecio.Text = row.Precio.ToString();
					txtX.Text = row.X.ToString();
					txtY.Text = row.Y.ToString();
					txtZ.Text = row.Z.ToString();
				}
			}
		}

		private void txtIdTipo_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (int.TryParse(txtIdTipo.Text, out int idMaterial))
			{
				TipoMaterialBL MaquinariaBL = new TipoMaterialBL();
				TipoMaterial maquinaria = MaquinariaBL.MostrarPorIdTipo(idMaterial);
				if (maquinaria != null)
				{
					cbTipoMaterial.Text = maquinaria.NombreTipo;
				}
			}
		}
	}
}
