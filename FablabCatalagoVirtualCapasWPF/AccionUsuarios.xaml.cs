using Fablab.esfe;
using MahApps.Metro.Controls;
using prototipos;
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
	/// Lógica de interacción para AccionUsuarios.xaml
	/// </summary>
	public partial class AccionUsuarios : MetroWindow
	{
		public AccionUsuarios()
		{
			InitializeComponent();
		}

		private void btnIngresar_Click(object sender, RoutedEventArgs e)
		{
			var ScAgg = new Window3();
			ScAgg.Show();
			this.Close();
        }

		private void btnModificar_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnEliminar_Click(object sender, RoutedEventArgs e)
		{
			var ScDel = new Window5();
			ScDel.Show();
			this.Close();
		}

		private void btnRegresar_Click(object sender, RoutedEventArgs e)
		{
			var ScBack = new SelecAdministrar();
			ScBack.Show();
			this.Close();
		}
	}
}
