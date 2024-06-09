using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasEN;

namespace FablabCatalagoVirtualCapasUI
{
	public partial class IngresarPrototipo : Form
	{
		public IngresarPrototipo()
		{
			InitializeComponent();
		}
		//metodo para validar que todos los textbox esten llenos
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
		//metodo para que la aplicacion se cierre al darle a la x 
		private void IngresarPrototipo_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
		//metodo para mostrar el formulario anterior
		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			var formRegresar = new AgregarPrototipo();
			formRegresar.Show();
		}
		//metodo para que el combobox se actulice con los datos dentro de la lista de materiales al cargar 
		//el formulario
		private void IngresarPrototipo_Load(object sender, EventArgs e)
		{
			var materialBL = new MaterialesBL();
			var EstadosBL = new EstadosBL();
			var maquinariaBL = new MaquinariaBL();
			cbMaterial.DataSource = materialBL.regresarLista();
			cbMaterial.DisplayMember = "nombreMaterial";
			cbMaterial.ValueMember= "Id";
			cbIdEstado.DataSource = EstadosBL.RegresarEstadosPrototipos();
			cbIdEstado.DisplayMember = "NombreEstado";
			cbIdEstado.ValueMember = "Id";
			cbMaquinaria.DataSource = maquinariaBL.MaquinariaList();
			cbMaquinaria.DisplayMember = "Nombre";
			cbMaquinaria.ValueMember = "Id";


		}
		//metodo para agregar un nuevo prototipo a la lista de prototipos
		private void btnConfirmar_Click(object sender, EventArgs e)
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

				MemoryStream ms = new MemoryStream();
				imgPrototipo.Image.Save(ms, ImageFormat.Jpeg);
				byte[] abyte = ms.ToArray();


			
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
					imgPrototipo.Image = null;
					txtX.Text = null;
					imgPrototipo.Image = Properties.Resources.imagepicturebox;
					MessageBox.Show("Los datos se han ingresado con exito");
				}
			}
			else
			{
				MessageBox.Show("porfavor rellene los correspondientees textboxx");
			}

		}

		//metodo para subir una imagen al picturebox
		private void imgPrototipo_Click(object sender, EventArgs e)
		{
			openFileDialog1 = new OpenFileDialog();
			openFileDialog1.Title = "Seleccionar iamgen";
			openFileDialog1.Filter = "Archivos de imagen *.jpg;*.jpeg;*.png;*.gif;*.bmp|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string rutaImagen = openFileDialog1.FileName;

				try
				{
					imgPrototipo.Image = Image.FromFile(rutaImagen);

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al cargar la imagen: " + ex.Message);
				}
			}
		}
	}
}
