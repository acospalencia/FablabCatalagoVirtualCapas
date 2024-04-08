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

		private void ModificarPrototipo_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

        private void ModificarPrototipo_Load(object sender, EventArgs e)
        {
			var regresarlista = new PrototipoBL();
			dgListado.DataSource = regresarlista.regresarlista();

		}

		private void btnRegresar_Click_1(object sender, EventArgs e)
		{
			var anteriorForm = new AgregarPrototipo();
			anteriorForm.Show();
			this.Hide();
		}

		private void dgListado_SelectionChanged(object sender, EventArgs e)
		{
			var ingresar = new MaterialesBL();
			cbMaterial.DataSource = ingresar.regresarLista();
			cbMaterial.DisplayMember = "nombreMaterial";
			if (dgListado != null && dgListado.SelectedRows.Count > 0 )
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
				}
            }
        }

		private void btnModificar_Click(object sender, EventArgs e)
		{
			var modificar = new Prototipo
			{
				Id = int.Parse(txtId.Text),
				NombrePrototipo = txtNombre.Text,
				TipoMaterial = cbMaterial.Text,
				Ancho = double.Parse(txtAncho.Text),
				Alto = double.Parse(txtAlto.Text),
				TiempoArmado = txtArmarlo.Text,
				TiempoDiseñado = txtDesign.Text,
				TiempoFabricado = txtFabricarlo.Text,
				Descripcion = txtDescripcion.Text
			};
            if (modificar != null)
            {
				var modificarLista = new PrototipoBL();
				modificarLista.Modificar(modificar);
				var Actualiazar = new PrototipoBL();
				dgListado.DataSource = null;
				dgListado.DataSource = Actualiazar.regresarlista();
				txtDescripcion.Text = null;
				txtAncho.Text = null;
				txtNombre.Text = null;
				txtAlto.Text = null;
				txtDesign.Text = null;
				txtArmarlo.Text = null;
				txtFabricarlo.Text = null;
			}
        }

		private void btnLupa_Click(object sender, EventArgs e)
		{
			//MessageBox.Show("esta es una funcion que pronto estara disponible");
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
				else
				{
					MessageBox.Show("Ingrese un número válido en el campo para buscar.");
				}
			}
		}
    }
}


