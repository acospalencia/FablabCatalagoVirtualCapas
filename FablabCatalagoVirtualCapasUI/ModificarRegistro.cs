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
    public partial class ModificarRegistro : Form
    {
        public ModificarRegistro()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formModified = new ModificarPrototipo();
            formModified.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formIngresarPrototipo = new IngresarPrototipo();
            formIngresarPrototipo.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var formEliminar = new EliminarPrototipo();
            formEliminar.Show();
            this.Hide();
        }
    }

}

