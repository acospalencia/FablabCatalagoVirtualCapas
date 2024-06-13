using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FablabCatalagoVirtualCapasUI
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

		public static string GetSHA256(string str)
		{
			SHA256 sha256 = SHA256Managed.Create();
			ASCIIEncoding encoding = new ASCIIEncoding();
			byte[] stream = null;
			StringBuilder sb = new StringBuilder();
			stream = sha256.ComputeHash(encoding.GetBytes(str));
			for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
			return sb.ToString();
		}

		private void btnRegresar_Click(object sender, EventArgs e)
        {
            var anteriorForm = new ModificarRegistro();
            anteriorForm.Show();
            this.Hide();
        }

        private bool Validar()
        {
            return !string.IsNullOrEmpty(txtNombre.Text) &&
                !string.IsNullOrEmpty(txtContraseña.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                var usuario = new User
                {
                    Usuario = txtNombre.Text,
                    Password = GetSHA256(txtContraseña.Text)
                };

                UserBL usuariobl = new UserBL();
                usuariobl.GuardarUser(usuario);
                txtNombre.Text = null;
                txtContraseña.Text = null;
                MessageBox.Show("El usuario se ha ingresado correctamente");
            }
            else
            {
				MessageBox.Show("Rellena los campos corespondientes porfavor");
			}
		}

		private void NuevoUsuario_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
