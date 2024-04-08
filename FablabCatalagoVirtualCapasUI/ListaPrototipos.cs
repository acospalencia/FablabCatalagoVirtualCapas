using FablabCatalagoVirtualCapasBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FablabCatalagoVirtualCapasUI
{
    public partial class ListaPrototipos : Form
    {
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
			var regresarLista = new PrototipoBL();
			dgvlistaprototipos.DataSource = regresarLista.regresarlista();
		}
		//metodo para que al seleccionar una fila en el datagrid la informacion se pase a los textbox
		private void dgvlistaprototipos_SelectionChanged(object sender, EventArgs e)
		{
			btnSiguiente.Visible = true;

            if (dgvlistaprototipos != null && dgvlistaprototipos.SelectedRows.Count > 0)
            {
				DataGridViewRow row = dgvlistaprototipos.SelectedRows[0];
                if (row != null)
                {
                    formInfo.lblNombre.Text += row.Cells[1].Value.ToString();
					formInfo.lblMaterial.Text += row.Cells[2].Value.ToString();
					formInfo.lblDescripcion.Text += row.Cells[5].Value.ToString();
				}
            }
        }
		//metodo para mostrar el siguiente formulario
		private void btnSiguiente_Click(object sender, EventArgs e)
		{
			formInfo.Show();
			this.Hide();
		}

	}
}
