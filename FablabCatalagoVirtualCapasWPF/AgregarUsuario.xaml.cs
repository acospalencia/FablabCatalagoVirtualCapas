using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasEN;
using FablabCatalagoVirtualCapasWPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace prototipos
{
	/// <summary>
	/// Lógica de interacción para Window3.xaml
	/// </summary>
	public partial class Window3 : Window
	{
		public Window3()
		{
			InitializeComponent();
		}
		private bool Validar()
		{
			return !string.IsNullOrEmpty(txtNombre.Text) &&
				!string.IsNullOrEmpty(txtContraseña.Text);
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

		private void btnRegresar_Click(object sender, RoutedEventArgs e)
		{
			var ScBack = new AccionUsuarios();
			ScBack.Show();
			this.Close();
		}

		private void btnGuardar_Click(object sender, RoutedEventArgs e)
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
	}
}
