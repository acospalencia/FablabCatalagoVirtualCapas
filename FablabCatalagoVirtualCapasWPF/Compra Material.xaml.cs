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
	/// Lógica de interacción para Compra_Material.xaml
	/// </summary>
	public partial class Compra_Material : Window
	{
		public Compra_Material()
		{
			InitializeComponent();
		}

		public bool Validar()
		{
			return !String.IsNullOrEmpty(txtCantidad.Text) &&
				!String.IsNullOrEmpty(txtPagar.Text) &&
				!String.IsNullOrEmpty(cbMaterial.Text) &&
				!String.IsNullOrEmpty(cbProveedor.Text);
		}

		private void dgVer_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (dgVer.SelectedItem != null)
			{
				try
				{
					var row = (CompraMate)dgVer.SelectedItem;
					btnEliminar.Visibility = Visibility.Visible;
					btnModificar.Visibility = Visibility.Visible;
					btnGuardar.Visibility = Visibility.Hidden;

					txtId.Text = row.Id.ToString();
					cbMaterial.SelectedValue = row.IdMaterial;
					cbProveedor.SelectedValue = row.IdProveedor;
					txtCantidad.Text = row.CantidadCompra;
					txtPagar.Text = row.TotalPagar.ToString();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al cargar los datos: " + ex.Message);
				}
				
			}
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			var CompraBL = new CompraMateBL();
			dgVer.ItemsSource = CompraBL.RegresarLista();

			var proveBL = new ProveedorBL();
			var mateBL = new MaterialesBL();
			cbProveedor.ItemsSource = proveBL.RegresarLista();
			cbProveedor.DisplayMemberPath = "Nombres";
			cbProveedor.SelectedValuePath = "Id";
			cbMaterial.ItemsSource = mateBL.regresarLista();
			cbMaterial.DisplayMemberPath = "NombreMaterial";
			cbMaterial.SelectedValuePath = "Id";
		}

		private void btnModificar_Click(object sender, RoutedEventArgs e)
		{
			if (Validar())
			{
				var ModificarCompra = new CompraMate
				{
					Id = int.Parse(txtId.Text),
					IdMaterial = Convert.ToInt32(cbMaterial.SelectedValue),
					IdProveedor = Convert.ToInt32(cbProveedor.SelectedValue),
					CantidadCompra = txtCantidad.Text,
					TotalPagar = decimal.Parse(txtPagar.Text)
				};

				var ModiCompra = new CompraMateBL();
				ModiCompra.ModificarCompra(ModificarCompra);
				dgVer.ItemsSource = null;
				dgVer.ItemsSource = ModiCompra.RegresarLista();

				txtCantidad.Text = null;
				txtPagar.Text = null;
				cbMaterial.Text = null;
				cbProveedor.Text = null;

				btnEliminar.Visibility = Visibility.Hidden;
				btnModificar.Visibility = Visibility.Hidden;
				btnGuardar.Visibility = Visibility.Visible;

				MessageBox.Show("Los datos se han actualizado con exito", "Correcto");
			}
			else
			{
				MessageBox.Show("Por favor rellene los correspondientes textbox", "Error");
			}
		}

		private void btnEliminar_Click(object sender, RoutedEventArgs e)
		{
			if (Validar())
			{
				var DeleteCompra = new CompraMate
				{
					Id = int.Parse(txtId.Text)
				};

				var EliminarCompra = new CompraMateBL();
				EliminarCompra.EliminarCompra(DeleteCompra);
				dgVer.ItemsSource = null;
				dgVer.ItemsSource = EliminarCompra.RegresarLista();

				txtCantidad.Text = null;
				txtPagar.Text = null;
				cbMaterial.Text = null;
				cbProveedor.Text = null;

				btnEliminar.Visibility = Visibility.Hidden;
				btnModificar.Visibility = Visibility.Hidden;
				btnGuardar.Visibility = Visibility.Visible;

				MessageBox.Show("Los datos se han eliminado con exito", "Correcto");
			}
			else
			{
				MessageBox.Show("Por favor rellene los correspondientes textbox", "Error");
			}
		}

		private void btnGuardar_Click(object sender, RoutedEventArgs e)
		{
			if (Validar())
			{
				var AddCompra = new CompraMate
				{
					IdMaterial = Convert.ToInt32(cbMaterial.SelectedValue),
					IdProveedor = Convert.ToInt32(cbProveedor.SelectedValue),
					CantidadCompra = txtCantidad.Text,
					TotalPagar = Convert.ToDecimal(txtPagar.Text)
				};

				var GuardarCompra = new CompraMateBL();
				GuardarCompra.GuardarCompra(AddCompra);
				dgVer.ItemsSource = null;
				dgVer.ItemsSource = GuardarCompra.RegresarLista();

				txtCantidad.Text = null;
				txtPagar.Text = null;
				cbMaterial.Text = null;
				cbProveedor.Text = null;


				MessageBox.Show("Los datos se han ingresado con exito", "Correcto");
			}
			else
			{
				MessageBox.Show("Por favor rellene los correspondientes textbox", "Error");
			}
		}
	}
}
