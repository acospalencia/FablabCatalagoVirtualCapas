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
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FablabCatalagoVirtualCapasWPF
{
	/// <summary>
	/// Lógica de interacción para InfoSoli.xaml
	/// </summary>
	public partial class InfoSoli : MetroWindow
	{
		public InfoSoli()
		{
			InitializeComponent();
		}

		private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
		{
			var AutorBL = new AutoresBL();

			cbIdAutor.ItemsSource = AutorBL.RegresarLista();
			cbIdAutor.DisplayMemberPath = "Nombres";
			cbIdAutor.SelectedValuePath = "Id";
		}

		private void btn_regresar_Click(object sender, RoutedEventArgs e)
		{
			var ScBack = new EliminarSolicitud();
			ScBack.Show();
			this.Close();
		}

		private void chkAprobar_Checked(object sender, RoutedEventArgs e)
		{
			ckNoAprovado.IsChecked = false;
		}

		private void chkNoAprobar_Checked(object sender, RoutedEventArgs e)
		{
			ckAprovado.IsChecked = false;
		}

		private void btnInfo_Click(object sender, RoutedEventArgs e)
		{
			string aprovado;

			if (ckAprovado.IsChecked == true)
            {
				 aprovado = "Aprobado";
            }
            else
            {
				 aprovado = "No Aprobado";
			}

			var soliAprova = new SolicitudProyectos
			{
				Id = Convert.ToInt32(lblId.Content),
				Estado = aprovado
			};

			var soliBL = new SolicitudProyectosBL();
			soliBL.ModificarAprobacion(soliAprova);

			var ScBack = new EliminarSolicitud();
			ScBack.Show();
			this.Close();
		}
	}
}
