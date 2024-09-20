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
	/// Lógica de interacción para IngresarMaquinaria.xaml
	/// </summary>
	public partial class IngresarMaquinaria : MetroWindow
	{
		public IngresarMaquinaria()
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

		private void btnRegresar_Click(object sender, RoutedEventArgs e)
		{
			var ScBack = new MantenimientoMaquinaria();
			ScBack.Show();
			this.Close();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			var estadosBL = new EstadosBL();
			cbIdEstado.ItemsSource = estadosBL.RegresarEstadosMaquinarias();
			cbIdEstado.DisplayMemberPath = "NombreEstado";
			cbIdEstado.SelectedValuePath = "Id";
		}

		private void btnGuardar_Click(object sender, RoutedEventArgs e)
		{
			if (Validar())
			{
				var GuardarMaqui = new Maquinaria
				{
					Nombre = txtNombre.Text,
					Marca = txtMarca.Text,
					Detalle = txtDetalle.Text,
					Idestado = Convert.ToInt32(cbIdEstado.SelectedValue)
				};

				var MaquiBL = new MaquinariaBL();
				MaquiBL.GuardarMaquinaria(GuardarMaqui);
				txtNombre.Text = null;
				txtMarca.Text = null;
				txtDetalle.Text = null;
				cbIdEstado.Text = null;

				MessageBox.Show("El registro ha sido guardado correctamente","Correcto" );

			}
			else
			{
				MessageBox.Show("Por favor rellenar los correspondientes textbox","Error");
			}
		}
	}
}
