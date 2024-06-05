﻿using System;
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
		//metodo para validar que todos los textbox esten llenos
		private bool validar()
		{
			return !string.IsNullOrEmpty(txtNombre.Text) &&
				!string.IsNullOrEmpty(cbMaterial.Text) &&
				!string.IsNullOrEmpty(txtAlto.Text) &&
				!string.IsNullOrEmpty(txtTiempo.Text) &&
				!string.IsNullOrEmpty(txtAutor.Text) &&
				!string.IsNullOrEmpty(txtArmarlo.Text) &&
				!string.IsNullOrEmpty(txtFabricarlo.Text) &&
				!string.IsNullOrEmpty(txtDescripcion.Text) &&
				!string.IsNullOrEmpty(txtAncho.Text);
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
			cbMaterial.DataSource = materialBL.regresarLista();
			cbMaterial.DisplayMember = "nombreMaterial";
			
		}
		//metodo para agregar un nuevo prototipo a la lista de prototipos
		private void btnConfirmar_Click(object sender, EventArgs e)
		{
			if (validar())
			{
				var Guardardatos = new Prototipo
				{
					//NombrePrototipo = txtNombre.Text,
					//TipoMaterial = cbMaterial.Text,
					//Ancho = double.Parse(txtAncho.Text),
					//Alto = double.Parse(txtAlto.Text),
					//Descripcion = txtDescripcion.Text,
					//ImagenPrototipo = imgPrototipo.Image,
					//TiempoDiseñado = txtTiempo.Text,
					//TiempoArmado = txtArmarlo.Text,
					//TiempoFabricado = txtFabricarlo.Text,
					//Autor = txtAutor.Text

				};
				if (Guardardatos != null)
				{
					var guardarInfo = new PrototipoBL();
					guardarInfo.Guardar(Guardardatos);
					txtDescripcion.Text = null;
					txtAncho.Text = null;
					txtNombre.Text = null;
					txtAlto.Text = null;
					txtTiempo.Text = null;
					txtArmarlo.Text = null;
					txtFabricarlo.Text = null;
					imgPrototipo.Image = null;
					txtAutor.Text = null;
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
