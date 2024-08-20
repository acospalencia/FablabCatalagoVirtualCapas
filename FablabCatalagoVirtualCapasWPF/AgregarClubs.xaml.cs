using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasEN;
using interfaces;
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
	/// Lógica de interacción para AgregarClubs.xaml
	/// </summary>
	public partial class AgregarClubs : Window
	{
		public AgregarClubs()
		{
			InitializeComponent();
		}

		public bool Validar()
		{
			return !string.IsNullOrEmpty(txtNombreClub.Text);
		}

		private void btnGuardar_Click(object sender, RoutedEventArgs e)
		{
            if (Validar())
            {
				var AddClub = new Club
				{
					NombreClub = txtNombreClub.Text,
				};

				var agregar = new ClubBL();
				agregar.GuardarClub(AddClub);

				txtNombreClub.Text = null;

				MessageBox.Show("Los datos han sido guardado correctamente", "Correcto");
			}
            else
            {
				MessageBox.Show("Por favor llenar los correspondientes textbox", "Error");
            }
        }

		private void btn_regresar_Click(object sender, RoutedEventArgs e)
		{
			var ScBack = new MantenimientoClubs();
			ScBack.Show();
			this.Close();
		}

		private void btnIncripcion_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
