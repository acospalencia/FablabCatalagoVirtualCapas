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
using System.Windows.Shapes;
using UI;

namespace Fablab.esfe
{
    /// <summary>
    /// Lógica de interacción para RegistrarMaterial.xaml
    /// </summary>
    public partial class RegistrarMaterial : Window
    {
        public RegistrarMaterial()
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
			this.Hide();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			var tipo = new TipoMaterialBL();
			cbTipoMaterial.ItemsSource = tipo.regresarTipoMaterial();
			cbTipoMaterial.DisplayMemberPath = "NombreTipo";
			cbTipoMaterial.SelectedValuePath = "Id";
		}

		private void btnRegistrar_Click(object sender, RoutedEventArgs e)
		{
			if (validacion())
			{
				var nuevoMateria = new Materiales
				{
					NombreMaterial = txtNombre.Text,
					X = txtX.Text,
					Y = txtY.Text,
					Z = txtZ.Text,
					Precio = decimal.Parse(txtPrecio.Text),
					IdTipoMaterial = Convert.ToInt32(cbTipoMaterial.SelectedValue)
				};

				var guardar = new MaterialesBL();
				guardar.guardarMaterial(nuevoMateria);
				txtZ.Text = null;
				txtPrecio.Text = null;
				txtY.Text = null;
				txtX.Text = null;
				txtNombre.Text = null;
				cbTipoMaterial.Text = null;
				MessageBox.Show("Los datos se han ingresado con exito");
			}
			else
			{
				MessageBox.Show("porfavor rellene los correspondientees textbox");
			}
		}

		private void Window_Closed(object sender, EventArgs e)
		{
			Application.Current.Shutdown();

		}
	}
}
