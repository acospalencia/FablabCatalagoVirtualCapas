using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasEN;
using FablabCatalagoVirtualCapasWPF;
using interfaces;
using MahApps.Metro.Controls;
using Microsoft.Win32;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prototipos
{
	/// <summary>
	/// Lógica de interacción para MainWindow.xaml
	/// </summary>
	public partial class MainWindow : MetroWindow
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		private bool validar()
		{
			return !string.IsNullOrEmpty(txtNombre.Text) &&
				!string.IsNullOrEmpty(cbMaterial.Text) &&
				!string.IsNullOrEmpty(txtZ.Text) &&
				!string.IsNullOrEmpty(txtDesign.Text) &&
				!string.IsNullOrEmpty(txtX.Text) &&
				!string.IsNullOrEmpty(txtArmarlo.Text) &&
				!string.IsNullOrEmpty(txtFabricarlo.Text) &&
				!string.IsNullOrEmpty(txtDescripcion.Text) &&
				!string.IsNullOrEmpty(txtY.Text);
		}

		private void btnRegresar_Click(object sender, RoutedEventArgs e)
		{
			var ScBack = new RegistrarPrototipos();
			ScBack.Show();
			this.Close();
		}

		private void btnAgg_Click(object sender, RoutedEventArgs e)
		{

			
			if (validar())
			{
				var duracion = new Duraciones
				{
					TiempoDiseno = txtDesign.Text,
					TiempoArmado = txtArmarlo.Text,
					TiempoFabricado = txtFabricarlo.Text
				};

				var gurdarduraciones = new DuracionesBL();
				gurdarduraciones.GuardarDuracion(duracion);

				BitmapSource bitmapSource = (BitmapSource)imgPrototipo.Source;
				byte[] abyte = null;


				if (bitmapSource != null)
				{
					using (MemoryStream ms = new MemoryStream())
					{
						JpegBitmapEncoder encoder = new JpegBitmapEncoder();
						encoder.Frames.Add(BitmapFrame.Create(bitmapSource));
						encoder.Save(ms);

						abyte = ms.ToArray();
					}
				}

				var durabl = new DuracionesBL();

				var Guardardatos = new Prototipo
				{
					NombrePrototipo = txtNombre.Text,
					IdMaterial = Convert.ToInt32(cbMaterial.SelectedValue),
					X = txtX.Text,
					Y = txtY.Text,
					Z = txtZ.Text,
					Descripcion = txtDescripcion.Text,
					Imagen = abyte,
					IdDuracion = durabl.RegresarId(),
					IdEstado = Convert.ToInt32(cbIdEstado.SelectedValue),
					IdMaquinaria = Convert.ToInt32(cbMaquinaria.SelectedValue)

				};
				if (Guardardatos != null)
				{
					var guardarInfo = new PrototipoBL();
					guardarInfo.Guardar(Guardardatos);
					txtDescripcion.Text = null;
					txtY.Text = null;
					txtNombre.Text = null;
					txtZ.Text = null;
					txtDesign.Text = null;
					txtArmarlo.Text = null;
					txtFabricarlo.Text = null;
					imgPrototipo.Source = null;
					txtX.Text = null;

					var ScCrea = new CreacionPrototipo();
					ScCrea.ShowDialog();
				}
			}
			else
			{
				MessageBox.Show("porfavor rellene los correspondientes textbox");
			}
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			var materialBL = new MaterialesBL();
			var EstadosBL = new EstadosBL();
			var maquinariaBL = new MaquinariaBL();
			cbMaterial.ItemsSource = materialBL.regresarLista();
			cbMaterial.DisplayMemberPath = "NombreMaterial";
			cbMaterial.SelectedValuePath = "Id";
			cbIdEstado.ItemsSource = EstadosBL.RegresarEstadosPrototipos();
			cbIdEstado.DisplayMemberPath = "NombreEstado";
			cbIdEstado.SelectedValuePath = "Id";
			cbMaquinaria.ItemsSource = maquinariaBL.MaquinariaList();
			cbMaquinaria.DisplayMemberPath = "Nombre";
			cbMaquinaria.SelectedValuePath = "Id";
		}

		private void btnAddFoto_Click(object sender, RoutedEventArgs e)
		{
			var SubirImagen = new Microsoft.Win32.OpenFileDialog();
			SubirImagen.Title = "Seleccionar imagen";
			SubirImagen.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

			if (SubirImagen.ShowDialog() == true)
			{
				string rutaImagen = SubirImagen.FileName;

				try
				{
					BitmapImage bitmap = new BitmapImage();
					bitmap.BeginInit();
					bitmap.UriSource = new Uri(rutaImagen);
					bitmap.CacheOption = BitmapCacheOption.OnLoad;
					bitmap.EndInit();

					imgPrototipo.Source = bitmap;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al cargar la imagen: " + ex.Message);
				}
			}
		}
	}
}
