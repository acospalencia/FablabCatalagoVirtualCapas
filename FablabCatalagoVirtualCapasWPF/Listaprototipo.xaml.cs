using System;
using System.Collections.Generic;
using System.IO;
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
using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasEN;

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

		public InformacionPrototipo formInfo = new InformacionPrototipo();

		private void btn_regresar_Click(object sender, RoutedEventArgs e)
		{
			var ScMain = new PantallaPrincipal();
			ScMain.Show();
			this.Close();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			ModeloPrototipoBL regresarLista = new ModeloPrototipoBL();
			dgvlistaprototipos.ItemsSource = null;
			dgvlistaprototipos.ItemsSource = regresarLista.RegresarListaModelo();
		}

		private void dgvlistaprototipos_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
            if (dgvlistaprototipos.SelectedItem != null)
            {
                var row = (ModeloPrototipo)dgvlistaprototipos.SelectedItem;

                if (row != null)
                {
                    txtNombre.Text = row.Nombre;
                    btnSiguiente.Visibility = Visibility.Visible;
                }
            }
        }

		private void btnSiguiente_Click(object sender, RoutedEventArgs e)
		{
			formInfo.Show();
			this.Close();
			var protoinfo = new Prototipo
			{
				NombrePrototipo = txtNombre.Text
			};
			ModeloProto2BL MaquinariaBL = new ModeloProto2BL();
			ModeloProto2 prototipos = MaquinariaBL.MostrarPrototi(protoinfo);
			if (protoinfo != null)
			{
				formInfo.lblNombre.Content += prototipos.NombrePrototipo;
				formInfo.lblNombreMat.Content += prototipos.NombreMaterial;
				formInfo.lblX.Content += prototipos.X;
				formInfo.lblY.Content += prototipos.Y;
				formInfo.lblZ.Content += prototipos.Z;
				formInfo.lblDescripcion.Content += prototipos.Descripcion;
				formInfo.lbldiseno.Content += prototipos.TiempoDiseno;
				formInfo.lblFabricado.Content += prototipos.TiempoFabricado;
				formInfo.lblArmado.Content += prototipos.TiempoArmado;
				formInfo.lblEstado.Content += prototipos.NombreEstado;
				formInfo.lblMaquina.Content += prototipos.Nombre;

				byte[] imagenBytes = (byte[])prototipos.Imagen;
				using (MemoryStream ms = new MemoryStream(imagenBytes))
				{
					BitmapImage bitmap = new BitmapImage();
					bitmap.BeginInit();
					bitmap.StreamSource = ms;
					bitmap.CacheOption = BitmapCacheOption.OnLoad;
					bitmap.EndInit();

					formInfo.imgPrototipo.Source = bitmap;
				}
			}
			
		}

		private void Window_Closed(object sender, EventArgs e)
		{
			this.Close();
		}
    }
}
