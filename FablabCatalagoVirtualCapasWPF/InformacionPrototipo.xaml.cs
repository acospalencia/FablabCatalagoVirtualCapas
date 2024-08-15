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

namespace Fablab.esfe
{
	/// <summary>
	/// Lógica de interacción para InformacionPrototipo.xaml
	/// </summary>
	public partial class InformacionPrototipo : Window
	{
		public InformacionPrototipo()
		{
			InitializeComponent();
		}

		private void Window_Closed(object sender, EventArgs e)
		{
			Application.Current.Shutdown();
		}

		private void btn_regresar_Click(object sender, RoutedEventArgs e)
		{

			var ScLista = new Listaprototipo();
			ScLista.Show();
			this.Hide();

		}
	}
}
