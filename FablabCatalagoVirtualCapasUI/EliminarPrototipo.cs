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
    public partial class EliminarPrototipo : Form
    {
        public EliminarPrototipo()
        {
            InitializeComponent();
        }

        private void EliminarPrototipo_Load(object sender, EventArgs e)
        {
			var regresarLista = new PrototipoBL();
			dgVer.DataSource = regresarLista.regresarlista();
		}

		private void EliminarPrototipo_FormClosing(object sender, FormClosingEventArgs e)
		{
            Application.Exit();
		}

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			var anteriorForm = new AgregarPrototipo();
			anteriorForm.Show();
			this.Hide();
		}

		private void dgVer_SelectionChanged(object sender, EventArgs e)
		{
            if (dgVer != null && dgVer.SelectedRows.Count > 0)
            {
				DataGridViewRow row = dgVer.SelectedRows[0];
                if (row != null)
                {
                    txtId.Text = row.Cells[0].Value.ToString();
                }
            }
        }

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			var borrarProto = new Prototipo
			{
				Id = int.Parse(txtId.Text)
			};
            if (borrarProto != null)
            {
				var eliminarProto = new PrototipoBL();
				eliminarProto.Eliminar(borrarProto);
				var actuaLista = new PrototipoBL();
				dgVer.DataSource = null;
				dgVer.DataSource = actuaLista.regresarlista();
			}
        }
	}
}
