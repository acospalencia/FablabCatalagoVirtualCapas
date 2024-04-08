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
		//metodo para verificar si la credenciales ingresadas son correctas
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
                var formAgregar = new ElegirAccion();
                formAgregar.Show();
                this.Hide();

            }
            else
			{
                MessageBox.Show("Revise las credenciales ingresadas por favor", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
		//metodo para mostrar el formulario anterior
		private void btnRegresar_Click(object sender, EventArgs e)
		{
            var formPrincipal = new PantallaPrincipal();
            formPrincipal.Show();
            this.Hide();
		}
		//metodo para que la aplicacion se cierre al darle a la x 
		private void Login_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
        //metodo para eliminar lo que hay dentro de el txtbox y cambiarle el color
		private void txtUsuario_MouseClick(object sender, MouseEventArgs e)
		{
            txtUsuario.Text = "";
            txtUsuario.ForeColor = SystemColors.WindowText;
		}
		//metodo para eliminar lo que hay dentro de el txtbox y cambiarle el color
		private void txtPassword_MouseClick(object sender, MouseEventArgs e)
		{
			txtPassword.Text = "";
			txtPassword.ForeColor = SystemColors.WindowText;
		}
	}
}
