using FablabCatalagoVirtualCapasWPF;
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

		private void btnMaterial_Click(object sender, RoutedEventArgs e)
		{
            var ScMat = new Accion_Material();
            ScMat.Show();
            this.Close();
        }

		private void btn_regresar_Click(object sender, RoutedEventArgs e)
		{
            var ScMain = new PantallaPrincipal();
            ScMain.Show();
            this.Close();
		}

		private void btnProto_CLick(object sender, RoutedEventArgs e)
		{
            var ScProto = new RegistrarPrototipos();
            ScProto.Show();
            this.Close();
        }

		private void btnUsuarios_Click(object sender, RoutedEventArgs e)
		{
            var ScUsu = new AccionUsuarios();
			ScUsu.Show();
            this.Close();
        }

		private void btnMaquinaria_Click(object sender, RoutedEventArgs e)
		{
            var ScMaq = new MantenimientoMaquinaria();
            ScMaq.Show();
            this.Close();
		}

		private void btnProveedor_Click(object sender, RoutedEventArgs e)
		{
            var ScProve = new Registrar_Proveedor();
            ScProve.Show();
            this.Close();
		}
	}
}
