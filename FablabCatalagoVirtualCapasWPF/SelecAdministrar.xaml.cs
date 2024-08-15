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
    /// Lógica de interacción para SelecAdministrar.xaml
    /// </summary>
    public partial class SelecAdministrar : Window
    {
        public SelecAdministrar()
        {
            InitializeComponent();
        }

		private void Button_Click(object sender, RoutedEventArgs e)
		{
            var ScMat = new Accion_Material();
            ScMat.Show();
            this.Hide();
        }

		private void btn_regresar_Click(object sender, RoutedEventArgs e)
		{
            var ScMain = new PantallaPrincipal();
            ScMain.Show();
            this.Hide();
		}

		private void Window_Closed(object sender, EventArgs e)
		{
			Application.Current.Shutdown();

		}
	}
}
