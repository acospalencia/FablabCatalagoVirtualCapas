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

		private void btn_regresar_Click(object sender, RoutedEventArgs e)
		{
			var ScBack = new Accion_Material();
			ScBack.Show();
			this.Hide();
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

		private void Window_Closed(object sender, EventArgs e)
		{
			Application.Current.Shutdown();
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
	}
}
