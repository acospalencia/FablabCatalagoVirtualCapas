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
    public partial class EliminarMateriales : Form
    {
        public EliminarMateriales()
        {
            InitializeComponent();
        }

        //metodo para que al cargar el formulario se actualice el datagrid con la informacion dentro de el listado prototipos
        private void EliminarMateriales_Load(object sender, EventArgs e)
        {
            var regresarLista = new MaterialesBL();
            dgVer.DataSource = regresarLista.regresarLista();
        }
        //metodo para que la aplicacion se cierre al darle a la x 
        private void EliminarMateriales_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //metodo para mostrar el formulario anterior
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var anteriorForm = new AccionMaterial();
            anteriorForm.Show();
            this.Hide();
        }
        //metodo para que se mande la informacion de las celdas de la linea seleccionada en el datagrid
        private void dgVer_SelectionChanged(object sender, EventArgs e)
        {
            if (dgVer != null && dgVer.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgVer.SelectedRows[0];
                if (row != null)
                {
                    btnEliminar.Enabled = true;
                    txtId.Text = row.Cells[0].Value.ToString();
                }
            }
        }
        //metodo del boton para eliminar el material de la lista seleccionada del datagrid
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var borrarMat = new Materiales
            {
                Id = int.Parse(txtId.Text)
            };
            if (borrarMat != null)
            {
                var eliminarMat = new MaterialesBL();
                eliminarMat.eliminarMaterial(borrarMat);
                var actuaLista = new MaterialesBL();
                dgVer.DataSource = null;
                dgVer.DataSource = actuaLista.regresarLista();
                txtId.Text = null;
                btnEliminar.Enabled = false;
                MessageBox.Show("Los datos se han Eliminado con exito");
            }
        }
        //metodo para buscar un material dentro de el datagrid por el ID
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
			if (string.IsNullOrEmpty(txtbuscar.Text) || txtbuscar.Text == "0")
			{
				var regresarlista = new MaterialesBL();
				dgVer.DataSource = regresarlista.regresarLista();
			}
			else
			{
				var Lista = new MaterialesBL();
				var textoBusqueda = txtbuscar.Text.ToLower();
				var usuariosFiltrados = Lista.regresarLista().Where(p => p.NombreMaterial.ToLower().Contains(textoBusqueda)).ToList();
				dgVer.DataSource = usuariosFiltrados;
			}
			if (!string.IsNullOrEmpty(txtbuscar.Text) && int.TryParse(txtbuscar.Text, out int idBuscada))
			{
				var Lista2 = new PrototipoBL();
				var prototiposFiltrados = Lista2.regresarlista().Where(p => p.Id == idBuscada).ToList();
				dgVer.DataSource = prototiposFiltrados;
			}
		}
    }
}
