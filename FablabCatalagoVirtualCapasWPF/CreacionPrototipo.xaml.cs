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
	/// Lógica de interacción para CreacionPrototipo.xaml
	/// </summary>
	public partial class CreacionPrototipo : MetroWindow
	{
		public CreacionPrototipo()
		{
			InitializeComponent();
		}

		public bool Validar()
		{
			return !string.IsNullOrEmpty(txtIntegrantes.Text) &&
				!string.IsNullOrEmpty(txtNombres.Text) &&
				!string.IsNullOrEmpty(cbAutor.Text) &&
				!string.IsNullOrEmpty(cbUsuario.Text) &&
				!string.IsNullOrEmpty(dpFecha.Text);
		}

		private void btnAgg_Click(object sender, RoutedEventArgs e)
		{
            if (Validar())
            {
				var proto = new PrototipoBL();
				var CreaProto = new CreacionProto
				{
					IdAutorLider = Convert.ToInt32(cbAutor.SelectedValue),
					IdPrototipo = proto.RegresarIdProto(),
					IdUsuario = Convert.ToInt32(cbUsuario.SelectedValue),
					FechaCreacion = dpFecha.SelectedDate.Value,
					NumeroAutoresEquipo = txtIntegrantes.Text,
					Nombres = txtNombres.Text
				};
				var	Guardar = new CreacionProtoBL();
				Guardar.GuardarCrea(CreaProto);

				MessageBox.Show("Los datos se han ingresado con exito");
				this.Close();
			}
            else
            {
				MessageBox.Show("Por favor rellene los correspondientes textbox");
			}
        }

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			var autorBL = new AutoresBL();
			var UserBL = new UserBL();
			cbAutor.ItemsSource = autorBL.RegresarLista();
			cbAutor.DisplayMemberPath = "Nombres";
			cbAutor.SelectedValuePath = "Id";
			cbUsuario.ItemsSource = UserBL.regresarLista();
			cbUsuario.DisplayMemberPath = "Usuario";
			cbUsuario.SelectedValuePath = "Id";

			dpFecha.SelectedDate = DateTime.Now;

		}
    }
}
