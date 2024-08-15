using System.Windows;

namespace Fablab.esfe
{
	/// <summary>
	/// Lógica de interacción para PantallaPrincipal.xaml
	/// </summary>
	public partial class PantallaPrincipal : Window
	{
		public PantallaPrincipal()
		{
			InitializeComponent();
		}

		private void BtnAdministrar_Click(object sender, RoutedEventArgs e)
		{
			var ScInicio = new InicioSesion();
			ScInicio.Show();
			this.Hide();
		}

		private void btnListado_Click(object sender, RoutedEventArgs e)
		{
			var ScListado = new Listaprototipo();
			ScListado.Show();
			this.Hide();
		}

		private void Window_Closed(object sender, System.EventArgs e)
		{
			Application.Current.Shutdown();

		}
	}
}
