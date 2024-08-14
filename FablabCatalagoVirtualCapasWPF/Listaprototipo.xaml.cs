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
    /// Lógica de interacción para Listaprototipo.xaml
    /// </summary>
    public partial class Listaprototipo : Window
    {
        public Listaprototipo()
        {
            InitializeComponent();
        }

		private void btn_regresar_Click(object sender, RoutedEventArgs e)
		{
			var ScMain = new PantallaPrincipal();
			ScMain.Show();
			this.Close();
		}
    }
}
