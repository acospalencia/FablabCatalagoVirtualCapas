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

        private void label3_Click(object sender, EventArgs e)
        {

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
                    txtPrecio.Text = row.Cells[3].Value.ToString();
					txtTiempo.Text = row.Cells[7].Value.ToString();
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
				TiempoTranscurrido = double.Parse(txtTiempo.Text),
				Precio = double.Parse(txtTiempo.Text)
			};
            if (modificar != null)
            {
				var modificarLista = new PrototipoBL();
				modificarLista.Modificar(modificar);
				var Actualiazar = new PrototipoBL();
				dgListado.DataSource = null;
				dgListado.DataSource = Actualiazar.regresarlista();
			}
        }
	}
}


