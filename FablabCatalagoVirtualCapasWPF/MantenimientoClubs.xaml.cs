using Fablab.esfe;
using FablabCatalagoVirtualCapasWPF;
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
    /// Lógica de interacción para MantenimientoClubs.xaml
    /// </summary>
    public partial class MantenimientoClubs : MetroWindow
    {
        public MantenimientoClubs()
        {
            InitializeComponent();
        }

		private void btnRegresar_Click(object sender, RoutedEventArgs e)
		{
            var ScBack = new SelecAdministrar();
            ScBack.Show();
            this.Close();
        }

		private void tbnRegresar_Click(object sender, RoutedEventArgs e)
		{
            var ScAdd = new AgregarClubs();
            ScAdd.Show();
            this.Close();
		}

		private void btnIngresar_Click(object sender, RoutedEventArgs e)
		{
            var ScModi = new ModificarClubs();
            ScModi.Show();
            this.Close();
		}
	}
}
