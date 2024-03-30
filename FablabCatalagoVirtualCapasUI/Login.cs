using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FablabCatalagoVirtualCapasEN;
using FablabCatalagoVirtualCapasBL;

namespace FablabCatalagoVirtualCapasUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblClave_Click(object sender, EventArgs e)
        {

        }

		private void btnIngresar_Click(object sender, EventArgs e)
		{
            var inicioSesion = new User   
            {
                Name = txtUsuario.Text,
                Password = txtPassword.Text
            };
            var verificar = new UserBL();
            var verificarUsuario = verificar.regresarLista().FirstOrDefault(i => i.Name == inicioSesion.Name && i.Password == inicioSesion.Password);

            if (verificarUsuario != null)
			{
                MessageBox.Show("inicio de sesion existoso");
                var formAgregar = new AgregarPrototipo();
                formAgregar.Show();
                this.Close();

            }
            else
			{
                MessageBox.Show("Revise las credenciales ingresadas por favor", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
	}
}
