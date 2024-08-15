using Fablab.esfe;
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

namespace UI
{
    /// <summary>
    /// Lógica de interacción para Accion_Material.xaml
    /// </summary>
    public partial class Accion_Material : Window
    {
        public Accion_Material()
        {
            InitializeComponent();
        }

		private void btn_regresar_Click(object sender, RoutedEventArgs e)
		{
			var ScBack = new SelecAdministrar();
			ScBack.Show();
			this.Close();
		}

		private void btnAgregar_Click(object sender, RoutedEventArgs e)
		{
			var ScAgg = new RegistrarMaterial();
			ScAgg.Show();
			this.Close();
		}

		private void btnModificar_Click(object sender, RoutedEventArgs e)
		{
			var ScAgg = new Modificar_Material();
			ScAgg.Show();
			this.Close();
		}
	}
}
