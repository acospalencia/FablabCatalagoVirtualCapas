﻿using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FablabCatalagoVirtualCapasUI
{
	public partial class ModificarPrototipo : Form
	{
		public ModificarPrototipo()
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
		private void ModificarPrototipo_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
		//metodo para que al cargar el formulario se actualice el datagrid con los datos de la lista
		private void ModificarPrototipo_Load(object sender, EventArgs e)
		{
			var regresarlista = new PrototipoBL();
			dgListado.DataSource = regresarlista.regresarlista();

		}
		//metodo para mostrar el formulario anterior
		private void btnRegresar_Click_1(object sender, EventArgs e)
		{
			var anteriorForm = new AgregarPrototipo();
			anteriorForm.Show();
			this.Hide();
		}
		//metodo para que al seleccionar una fila en el datagrid la informacion se pase a los textbox
		private void dgListado_SelectionChanged(object sender, EventArgs e)
		{
			var ingresar = new MaterialesBL();
			var materialBL = new MaterialesBL();
			var EstadosBL = new EstadosBL();
			var maquinariaBL = new MaquinariaBL();
			cbMaterial.DataSource = ingresar.regresarLista();
			cbMaterial.DisplayMember = "nombreMaterial";
			cbMaterial.DataSource = materialBL.regresarLista();
			cbMaterial.DisplayMember = "nombreMaterial";
			cbMaterial.ValueMember = "Id";
			cbIdEstado.DataSource = EstadosBL.RegresarEstadosPrototipos();
			cbIdEstado.DisplayMember = "NombreEstado";
			cbIdEstado.ValueMember = "Id";
			cbMaquinaria.DataSource = maquinariaBL.MaquinariaList();
			cbMaquinaria.DisplayMember = "Nombre";
			cbMaquinaria.ValueMember = "Id";


			if (dgListado != null && dgListado.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dgListado.SelectedRows[0];
				if (row != null)
				{
					txtId.Text = row.Cells[0].Value.ToString();
					txtNombre.Text = row.Cells[1].Value.ToString();
					txtIdMaterial.Text = row.Cells[2].Value.ToString();
					txtX.Text = row.Cells[3].Value.ToString();
					txtY.Text = row.Cells[4].Value.ToString();
					txtZ.Text = row.Cells[5].Value.ToString();
					txtDescripcion.Text = row.Cells[6].Value.ToString();
					txtIdDuraciones.Text = row.Cells[8].Value.ToString();
					txtIdEstado.Text = row.Cells[9].Value.ToString();
					txtIdMaquinaria.Text = row.Cells[10].Value.ToString();
					if (row.Cells[7].Value != DBNull.Value)
					{
						byte[] imagenBytes = (byte[])row.Cells[7].Value;
						using (MemoryStream ms = new MemoryStream(imagenBytes))
						{
							img.Image = Image.FromStream(ms);
						}
					}
					else
					{
						img.Image = null;
					}
				}
			}
		}
		//metodo para asignar los valores a los atributos y que se actualice el prototipo seleccionado
		private void btnModificar_Click(object sender, EventArgs e)
		{
			if (validar())
			{	
				//MemoryStream ms = new MemoryStream();
				//img.Image.Save(ms, ImageFormat.Jpeg);
				//byte[] abyte = ms.ToArray();

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
					dgListado.DataSource = null;
					dgListado.DataSource = Actualiazar.regresarlista();
					txtId.Text = null;
					txtNombre.Text = null;
					cbMaterial.Text = null;
					txtX.Text = null;
					txtX.Text = null;
					txtZ.Text = null;
					txtDescripcion.Text = null;
					txtIdDuraciones.Text = null;
					cbIdEstado.Text = null;
					cbMaquinaria.Text = null;

					MessageBox.Show("Los datos se han Actualizado con exito");
				}

			}
			else
			{
				MessageBox.Show("porfavor rellene los correspondientees textbox");
			}
		}
		//metodo para buscar un objeto en la lista dependiendo en su Id
		private void txtbuscar_TextChanged(object sender, EventArgs e)
		{
			if (txtbuscar.Text == "" || txtbuscar.Text == "0" || txtbuscar.Text == null)
			{
				var regresarlista = new PrototipoBL();
				dgListado.DataSource = regresarlista.regresarlista();
			}

			if (!string.IsNullOrEmpty(txtbuscar.Text) && int.TryParse(txtbuscar.Text, out int idBuscada))
			{
				var Lista = new PrototipoBL();
				var prototiposFiltrados = Lista.regresarlista().Where(p => p.Id == idBuscada).ToList();
				dgListado.DataSource = prototiposFiltrados;
			}

		}

		private void txtIdDuraciones_TextChanged(object sender, EventArgs e)
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

		private void txtIdMaterial_TextChanged(object sender, EventArgs e)
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

		private void txtIdEstado_TextChanged(object sender, EventArgs e)
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

		private void txtIdMaquinaria_TextChanged(object sender, EventArgs e)
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
	}
}


