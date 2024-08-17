using Fablab.esfe;
using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasEN;
using interfaces;
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
using System.Windows.Shapes;

namespace prototipos
{
	/// <summary>
	/// Lógica de interacción para Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
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

		private void dgListado_SelectionChanged(object sender, SelectionChangedEventArgs e)
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

			if (dgListado.SelectedItem != null)
			{
				var row = (Prototipo)dgListado.SelectedItem;

				txtId.IsEnabled = true;
				txtNombre.IsEnabled = true;
				cbMaterial.IsEnabled = true;
				txtX.IsEnabled = true;
				txtY.IsEnabled = true;
				txtZ.IsEnabled = true;
				txtDesign.IsEnabled = true;
				txtArmarlo.IsEnabled = true;
				txtFabricarlo.IsEnabled = true;
				txtDescripcion.IsEnabled = true;
				cbIdEstado.IsEnabled = true;
				cbMaquinaria.IsEnabled = true;

				txtId.Text = row.Id.ToString();
				txtNombre.Text = row.NombrePrototipo;
				cbMaterial.SelectedValue = row.IdMaterial;
				txtX.Text = row.X.ToString();
				txtY.Text = row.Y.ToString();
				txtZ.Text = row.Z.ToString();
				txtDescripcion.Text = row.Descripcion;
				cbIdEstado.SelectedValue = row.IdEstado;
				cbMaquinaria.SelectedValue = row.IdMaquinaria;
				txtIdDuraciones.Text = row.IdDuracion.ToString();

				if (row.Imagen != null)
				{
					using (MemoryStream ms = new MemoryStream(row.Imagen))
					{
						BitmapImage bitmap = new BitmapImage();
						bitmap.BeginInit();
						bitmap.StreamSource = ms;
						bitmap.CacheOption = BitmapCacheOption.OnLoad;
						bitmap.EndInit();

						img.Source = bitmap;
					}
				}
				else
				{
					img.Source = null;
				}
			}
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			var regresarlista = new PrototipoBL();
			dgListado.ItemsSource = regresarlista.regresarlista();
		}

		private void txtIdMaterial_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (int.TryParse(txtIdMaterial.Text, out int idMaterial))
			{
				MaterialesBL materialesBL = new MaterialesBL();
				Materiales materiales = materialesBL.MostrarPorIdMateriales(idMaterial);
				if (materiales != null)
				{
					cbMaterial.Text = materiales.NombreMaterial;
				}

			}
		}

		private void txtIdEstado_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (int.TryParse(txtIdEstado.Text, out int idMaterial))
			{
				EstadosBL estadosBL = new EstadosBL();
				Estados estados = estadosBL.MostrarPorIdEstados(idMaterial);
				if (estados != null)
				{
					cbIdEstado.Text = estados.NombreEstado;
				}
			}
		}

		private void txtIdMaquinaria_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (int.TryParse(txtIdMaquinaria.Text, out int idMaterial))
			{
				MaquinariaBL MaquinariaBL = new MaquinariaBL();
				Maquinaria maquinaria = MaquinariaBL.MostrarPorIdMaquinaria(idMaterial);
				if (maquinaria != null)
				{
					cbMaquinaria.Text = maquinaria.Nombre;
				}
			}
		}

		private void txtIdDuraciones_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (int.TryParse(txtIdDuraciones.Text, out int idDuracion))
			{
				DuracionesBL duracionesBL = new DuracionesBL();
				Duraciones duracion = duracionesBL.MostrarPorIdDuraciones(idDuracion);
				if (duracion != null)
				{
					txtDesign.Text = duracion.TiempoDiseno;
					txtArmarlo.Text = duracion.TiempoArmado;
					txtFabricarlo.Text = duracion.TiempoFabricado;
				}
			}
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			var ScBack = new RegistrarPrototipos();
			ScBack.Show();
			this.Close();
		}

		private void btnModificar_Click(object sender, RoutedEventArgs e)
		{
			if (validar())
			{

				var duracionesModify = new Duraciones
				{
					Id = int.Parse(txtIdDuraciones.Text),
					TiempoDiseno = txtDesign.Text,
					TiempoFabricado = txtFabricarlo.Text,
					TiempoArmado = txtArmarlo.Text
				};

				var modificar = new Prototipo
				{
					Id = int.Parse(txtId.Text),
					NombrePrototipo = txtNombre.Text,
					IdMaterial = Convert.ToInt32(cbMaterial.SelectedValue),
					X = txtX.Text,
					Y = txtX.Text,
					Z = txtZ.Text,
					Descripcion = txtDescripcion.Text,
					IdDuracion = int.Parse(txtIdDuraciones.Text),
					IdEstado = Convert.ToInt32(cbIdEstado.SelectedValue),
					IdMaquinaria = Convert.ToInt32(cbMaquinaria.SelectedValue)

				};
				if (modificar != null)
				{
					var modifyDura = new DuracionesBL();
					modifyDura.ActualizarDuraciones(duracionesModify);
					var modificarLista = new PrototipoBL();
					modificarLista.Modificar(modificar);
					var Actualiazar = new PrototipoBL();
					dgListado.ItemsSource = null;
					cbMaterial.SelectedValue = Actualiazar;
					txtId.Text = null;
					txtNombre.Text = null;
					cbMaterial.Text = null;
					txtX.Text = null;
					txtY.Text = null;
					txtZ.Text = null;
					txtDesign.Text = null;
					txtArmarlo.Text = null;
					txtFabricarlo.Text = null;
					txtDescripcion.Text = null;
					txtIdDuraciones.Text = null;
					cbIdEstado.Text = null;
					cbMaquinaria.Text = null;
					txtId.IsEnabled = false;
					txtNombre.IsEnabled = false;
					cbMaterial.IsEnabled = false;
					txtX.IsEnabled = false;
					txtY.IsEnabled = false;
					txtZ.IsEnabled = false;
					txtDesign.IsEnabled = false;
					txtArmarlo.IsEnabled = false;
					txtFabricarlo.IsEnabled = false;
					txtDescripcion.IsEnabled = false;
					cbIdEstado.IsEnabled = false;
					cbMaquinaria.IsEnabled = false;

					MessageBox.Show("Los datos se han Actualizado con exito");
				}
				var regresarlista = new PrototipoBL();
				dgListado.ItemsSource = regresarlista.regresarlista();

			}
			else
			{
				MessageBox.Show("porfavor rellene los correspondientees textbox");
			}
		}

		private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (string.IsNullOrEmpty(txtbuscar.Text) || txtbuscar.Text == "0")
			{
				var regresarlista = new PrototipoBL();
				dgListado.ItemsSource = regresarlista.regresarlista();
			}
			else
			{
				var Lista = new PrototipoBL();
				var textoBusqueda = txtbuscar.Text.ToLower();
				var usuariosFiltrados = Lista.regresarlista().Where(p => p.NombrePrototipo.ToLower().Contains(textoBusqueda)).ToList();
				dgListado.ItemsSource = usuariosFiltrados;
			}
			if (!string.IsNullOrEmpty(txtbuscar.Text) && int.TryParse(txtbuscar.Text, out int idBuscada))
			{
				var Lista2 = new PrototipoBL();
				var prototiposFiltrados = Lista2.regresarlista().Where(p => p.Id == idBuscada).ToList();
				dgListado.ItemsSource = prototiposFiltrados;
			}
		}
	}
}
