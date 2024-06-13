using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FablabCatalagoVirtualCapasUI
{

	public partial class ListaPrototipos : Form
	{
		DataGridViewRow test;
		public ListaPrototipos()
		{
			InitializeComponent();
		}
		//metodo para hacer referencia a los label y textbox de otro formulario
		public InformacionPrototipos formInfo = new InformacionPrototipos();
		//metodo para que la aplicacion se cierre al darle a la x 
		private void ListaPrototipos_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
		//metodo para mostrar el formulario anterior
		private void btncancelar_Click_1(object sender, EventArgs e)
		{
			var formregresar = new PantallaPrincipal();
			formregresar.Show();
			this.Hide();
		}
		//metodo para que el datagrid se actualice al cargar el formulario
		private void ListaPrototipos_Load(object sender, EventArgs e)
		{
			ModeloPrototipoBL regresarLista = new ModeloPrototipoBL();
			dgvlistaprototipos.DataSource = null;
			dgvlistaprototipos.DataSource = regresarLista.RegresarListaModelo();
		}
		//metodo para que al seleccionar una fila en el datagrid la informacion se pase a los textbox
		private void dgvlistaprototipos_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvlistaprototipos != null && dgvlistaprototipos.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dgvlistaprototipos.SelectedRows[0];
				if (row != null)
				{
					txtNombre.Text = row.Cells[0].Value.ToString();
					btnSiguiente.Visible = true;
				}
			}
		}
		//metodo para mostrar el siguiente formulario
		private void btnSiguiente_Click(object sender, EventArgs e)
		{
			formInfo.Show();
			this.Hide();
			var protoinfo = new Prototipo
			{
				NombrePrototipo = txtNombre.Text
			};
			ModeloProto2BL MaquinariaBL = new ModeloProto2BL();
			ModeloProto2 prototipos = MaquinariaBL.MostrarPrototi(protoinfo);
			if (protoinfo != null)
			{
				formInfo.lblNombre.Text += prototipos.NombrePrototipo;
				formInfo.lblNombreMat.Text += prototipos.NombreMaterial;
				formInfo.lblX.Text += prototipos.X;
				formInfo.lblY.Text += prototipos.Y;
				formInfo.lblZ.Text += prototipos.Z;
				formInfo.lblDescripcion.Text += prototipos.Descripcion;
				formInfo.lbldiseno.Text += prototipos.TiempoDiseno;
				formInfo.lblFabricado.Text += prototipos.TiempoFabricado;
				formInfo.lblArmado.Text += prototipos.TiempoArmado;
				formInfo.lblEstado.Text += prototipos.NombreEstado;
				formInfo.lblMaquina.Text += prototipos.Nombre;

				byte[] imagenBytes = (byte[])prototipos.Imagen;
				using (MemoryStream ms = new MemoryStream(imagenBytes))
				{
					formInfo.imgProtoripo.Image = Image.FromStream(ms);
				}

			}

		}

		private void txtNombre_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
