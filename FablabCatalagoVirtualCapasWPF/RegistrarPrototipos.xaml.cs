using Fablab.esfe;
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

namespace interfaces
{
    /// <summary>
    /// Lógica de interacción para RegistrarPrototipos.xaml
    /// </summary>
    public partial class RegistrarPrototipos : Window
    {
        public RegistrarPrototipos()
        {
            InitializeComponent();
        }

		private void btnIngresar_Click(object sender, RoutedEventArgs e)
		{
            var ScAgg = new MainWindow();
            ScAgg.Show();
            this.Close();   

		}

		private void btnEliminar_Click(object sender, RoutedEventArgs e)
		{
			var ScDel = new Window2();
			ScDel.Show();
			this.Close();
		}

		private void btnRegresar_Click(object sender, RoutedEventArgs e)
		{
            var ScBack = new SelecAdministrar();
            ScBack.Show();
            this.Close();
		}

		private void btnModificar_Click(object sender, RoutedEventArgs e)
		{
			var ScModi = new Window1();
			ScModi.Show();
			this.Close();
		}
	}
}
