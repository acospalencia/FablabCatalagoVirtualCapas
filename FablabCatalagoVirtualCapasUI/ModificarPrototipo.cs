using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
				!string.IsNullOrEmpty(txtAlto.Text) &&
				!string.IsNullOrEmpty(txtDesign.Text) &&
				!string.IsNullOrEmpty(txtAutor.Text) &&
				!string.IsNullOrEmpty(txtArmarlo.Text) &&
				!string.IsNullOrEmpty(txtFabricarlo.Text) &&
				!string.IsNullOrEmpty(txtDescripcion.Text) &&
				!string.IsNullOrEmpty(txtAncho.Text);
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
			cbMaterial.DataSource = ingresar.regresarLista();
			cbMaterial.DisplayMember = "nombreMaterial";
			if (dgListado != null && dgListado.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dgListado.SelectedRows[0];
				if (row != null)
				{
					txtId.Text = row.Cells[0].Value.ToString();
					txtNombre.Text = row.Cells[1].Value.ToString();
					txtAlto.Text = row.Cells[3].Value.ToString();
					txtAncho.Text = row.Cells[4].Value.ToString();
					txtDescripcion.Text = row.Cells[5].Value.ToString();
					txtDesign.Text = row.Cells[7].Value.ToString();
					txtArmarlo.Text = row.Cells[8].Value.ToString();
					txtFabricarlo.Text = row.Cells[9].Value.ToString();
					txtAutor.Text = row.Cells[10].Value.ToString();
					cbMaterial.Text = row.Cells[2].Value.ToString();
					Image imagen  = (Image)row.Cells[6].Value;
					img.Image = imagen;
					
				}
			}
		}
		//metodo para asignar los valores a los atributos y que se actualice el prototipo seleccionado
		private void btnModificar_Click(object sender, EventArgs e)
		{
            if ( validar())
            {
				//var modificar = new Prototipo
				//{
				//	Id = int.Parse(txtId.Text),
				//	NombrePrototipo = txtNombre.Text,
				//	TipoMaterial = cbMaterial.Text,
				//	Ancho = double.Parse(txtAncho.Text),
				//	Alto = double.Parse(txtAlto.Text),
				//	TiempoArmado = txtArmarlo.Text,
				//	TiempoDiseñado = txtDesign.Text,
				//	TiempoFabricado = txtFabricarlo.Text,
				//	Descripcion = txtDescripcion.Text,
				//	Autor = txtAutor.Text,
				//	ImagenPrototipo = img.Image
				//};
				//if (modificar != null)
				//{
				//	var modificarLista = new PrototipoBL();
				//	modificarLista.Modificar(modificar);
				//	var Actualiazar = new PrototipoBL();
				//	dgListado.DataSource = null;
				//	dgListado.DataSource = Actualiazar.regresarlista();
				//	txtDescripcion.Text = null;
				//	txtAncho.Text = null;
				//	txtNombre.Text = null;
				//	txtAlto.Text = null;
				//	txtDesign.Text = null;
				//	txtArmarlo.Text = null;
				//	txtFabricarlo.Text = null;
				//	txtAutor.Text = null;
				//	img.Image = null;
				//	MessageBox.Show("Los datos se han Actualizado con exito");
				//}
            
			}
			else
			{
				MessageBox.Show("porfavor rellene los correspondientees textboxx");
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
	}
}


