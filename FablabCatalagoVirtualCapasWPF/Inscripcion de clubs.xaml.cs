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

namespace FablabCatalagoVirtualCapasWPF
{
	/// <summary>
	/// Lógica de interacción para Inscripcion_de_clubs.xaml
	/// </summary>
	public partial class Inscripcion_de_clubs : Window
	{
		public Inscripcion_de_clubs()
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

		private void btnGuardar_Click(object sender, RoutedEventArgs e)
		{
			if (Validar())
			{
				var AddInscripcion = new InscripcionClub
				{
					IdAutor = Convert.ToInt32(cbIdAutor.SelectedValue),
					IdClub = Convert.ToInt32(cbIdClub.SelectedValue),
					FechaInscripcion = dpFecha.SelectedDate.Value,
					Detalle = txtDetalle.Text,
				};

				var inscr = new InscripcionClubBL();
				inscr.AddInscripcion(AddInscripcion);

				txtDetalle.Text = null;
				cbIdAutor.Text = null;
				cbIdClub.Text = null;
				dpFecha.Text = null;

				MessageBox.Show("Los datos se han ingresado correctamente", "Correcto");

			}
			else
			{
				MessageBox.Show("Por favor rellenar los correspondientes textbox", "Error");
			}
		}

		private void btn_regresar_Click(object sender, RoutedEventArgs e)
		{
			var ScBack = new AgregarClubs();
			ScBack.Show();
			this.Close();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			var AutorBL = new AutoresBL();
			var ClubeBl = new ClubBL();

			cbIdAutor.ItemsSource = AutorBL.RegresarLista();
			cbIdAutor.DisplayMemberPath = "Nombres";
			cbIdAutor.SelectedValuePath = "Id";
			cbIdClub.ItemsSource = ClubeBl.RegresarLista();
			cbIdClub.DisplayMemberPath = "NombreClub";
			cbIdClub.SelectedValuePath = "Id";
		}
	}
}
