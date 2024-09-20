using Fablab.esfe;
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

namespace UI
{
    /// <summary>
    /// Lógica de interacción para Registrar_Proveedor.xaml
    /// </summary>
    public partial class Registrar_Proveedor : MetroWindow
    {
        public Registrar_Proveedor()
        {
            InitializeComponent();
        }

		private void btnRegresar_Click(object sender, RoutedEventArgs e)
		{
            var ScBack = new SelecAdministrar();
            ScBack.Show();
            this.Close();    
        }

		private void btnAgregar_Click(object sender, RoutedEventArgs e)
		{
			var ScAgg = new Agregar_Proveedor();
			ScAgg.Show();
			this.Close();
		}

		private void btnModificar_Click(object sender, RoutedEventArgs e)
		{
			var ScModi = new Modificar_Proveedor();
			ScModi.Show();
			this.Close();
		}

		private void btnEliminar_Click(object sender, RoutedEventArgs e)
		{
			var ScDel = new Eliminar_Proveedor();
			ScDel.Show();
			this.Close();
		}
	}
}
