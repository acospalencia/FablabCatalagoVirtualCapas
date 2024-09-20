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
	/// Lógica de interacción para IngresarAutores.xaml
	/// </summary>
	public partial class IngresarAutores : MetroWindow
	{
		public IngresarAutores()
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

		private void btnGuardar_Click(object sender, RoutedEventArgs e)
		{
			if (Validar())
			{
				var AddAutor = new Autores
				{
					Nombres = txtNombres.Text,
					Apellidos = txtApellidos.Text,
					CorreElectronico = txtCorreoElectronico.Text,
					FechaRegistro = dtFecha.SelectedDate.Value
				};

				var autorBL = new AutoresBL();
				autorBL.GuardarAutor(AddAutor);

				txtNombres.Text = null;
				txtApellidos.Text = null;
				txtCorreoElectronico.Text = null;
				dtFecha.SelectedDate = null;

				MessageBox.Show("Los datos se han ingresado con exito", "Correcto");

			}
			else
			{
				MessageBox.Show("Rellene los correspondientes textbox", "Error");
			}
		}
	}
}
