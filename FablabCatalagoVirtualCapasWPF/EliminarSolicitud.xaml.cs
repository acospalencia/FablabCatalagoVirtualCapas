using Fablab.esfe;
using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasEN;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FablabCatalagoVirtualCapasWPF
{
	/// <summary>
	/// Lógica de interacción para EliminarSolicitud.xaml
	/// </summary>
	public partial class EliminarSolicitud : MetroWindow
	{
		public EliminarSolicitud()
		{
			InitializeComponent();
		}

		public InfoSoli formInfo = new InfoSoli();

		private void btnRegresar_Click(object sender, RoutedEventArgs e)
		{
			var ScBack = new SelecAdministrar();
			ScBack.Show();
			this.Close();
		}

		private void dgVer_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (dgVer.SelectedItem != null)
			{
				var row = (SolicitudProyectos)dgVer.SelectedItem;

				txtId.Text = row.Id.ToString();

				btnEliminar.Visibility = Visibility.Visible;
			}
		}

		private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (string.IsNullOrEmpty(txtBuscar.Text) || txtBuscar.Text == "0")
			{
				var regresarlista = new SolicitudProyectosBL();
				dgVer.ItemsSource = regresarlista.RegresarLista();
			}
			else
			{
				var Lista = new SolicitudProyectosBL();
				var textoBusqueda = txtBuscar.Text.ToLower();
				var usuariosFiltrados = Lista.RegresarLista().Where(p => p.TipoProyecto.ToLower().Contains(textoBusqueda)).ToList();
				dgVer.ItemsSource = usuariosFiltrados;
			}
			if (!string.IsNullOrEmpty(txtBuscar.Text) && int.TryParse(txtBuscar.Text, out int idBuscada))
			{
				var Lista2 = new SolicitudProyectosBL();
				var prototiposFiltrados = Lista2.RegresarLista().Where(p => p.Id == idBuscada).ToList();
				dgVer.ItemsSource = prototiposFiltrados;
			}
		}

		private void btnEliminar_Click(object sender, RoutedEventArgs e)
		{
			var delSoli = new SolicitudProyectos
			{
				Id = Convert.ToInt32(txtId.Text),
			};
			var SoliBL = new SolicitudProyectosBL();
			SoliBL.EliminarSoli(delSoli);
			dgVer.ItemsSource = null;
			dgVer.ItemsSource = SoliBL.RegresarLista();

			btnEliminar.Visibility = Visibility.Hidden;
			btnInfo.Visibility = Visibility.Hidden;

			MessageBox.Show("Los datos se han eliminado con exito", "Correcto");
		}

		private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
		{
			var soliBL = new SolicitudProyectosBL();
			dgVer.ItemsSource = soliBL.RegresarLista();
		}

		private void btnInfo_Click(object sender, RoutedEventArgs e)
		{
			formInfo.Show();
			this.Close();
			var infoSoli = new SolicitudProyectos
			{
				Id = Convert.ToInt32(txtId.Text)
			};
			SolicitudProyectosBL solisbl = new SolicitudProyectosBL();
			SolicitudProyectos mostrarSoli = solisbl.MostrarInfo(infoSoli);
			if (infoSoli != null)
			{
				formInfo.lblId.Content = mostrarSoli.Id;
				formInfo.lblTipo.Content += mostrarSoli.TipoProyecto;
				formInfo.lblIntegrates.Content += mostrarSoli.Integrantes.ToString();
				formInfo.lblFecha.Content += mostrarSoli.Fecha.ToString();
				formInfo.lblDescripcion.Content += mostrarSoli.Descripcion;
				formInfo.cbIdAutor.SelectedValue = mostrarSoli.IdAutor;
                if (mostrarSoli.Estado == "Aprovado")
                {
					formInfo.ckAprovado.IsChecked = true;
                }
                else if(mostrarSoli.Estado == "No Aprovado")
                {
					formInfo.ckNoAprovado.IsChecked = true;
				}
            }


		}

		private void txtId_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (dgVer.SelectedItem != null)
			{
				var row = (SolicitudProyectos)dgVer.SelectedItem;

				if (row != null)
				{
					txtId.Text = row.Id.ToString();
					btnInfo.Visibility = Visibility.Visible;
				}
			}
		}
	}
}
