using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

		private void IngresarPrototipo_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			var formRegresar = new AgregarPrototipo();
			formRegresar.Show();
		}

		private void IngresarPrototipo_Load(object sender, EventArgs e)
		{
			cbMaterial.Text = "";
			var materialBL = new MaterialesBL();
			cbMaterial.DataSource = materialBL.regresarLista();
			cbMaterial.DisplayMember = "nombreMaterial";
		}

		private void btnConfirmar_Click(object sender, EventArgs e)
		{
			var Guardardatos = new Prototipo
			{
				NombrePrototipo = textBox1.Text,
				TipoMaterial = cbMaterial.Text,
				TiempoTranscurrido = double.Parse(textBox3.Text),
				Precio = double.Parse(textBox4.Text),
				Descripcion = textBox5.Text,
				ImagenPrototipo = pictureBox1.Image
			};
		}

		private void btnSubir_Click(object sender, EventArgs e)
		{
			openFileDialog1 = new OpenFileDialog();
			openFileDialog1.Title = "Seleccionar iamgen";
			openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string rutaImagen = openFileDialog1.FileName;

				try
				{
					// Cargar la imagen en el PictureBox
					pictureBox1.Image = Image.FromFile(rutaImagen);

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al cargar la imagen: " + ex.Message);
				}
			}
		}
	}
}
