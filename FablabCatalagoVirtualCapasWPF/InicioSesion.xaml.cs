﻿using System;
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
using FablabCatalagoVirtualCapasEN;
using FablabCatalagoVirtualCapasBL;
using MahApps.Metro.Controls;

namespace Fablab.esfe
{
    /// <summary>
    /// Lógica de interacción para InicioSesion.xaml
    /// </summary>
    public partial class InicioSesion : MetroWindow
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

		private bool Validar()
		{
			return !string.IsNullOrEmpty(txtUsuario.Text) &&
				!string.IsNullOrEmpty(txtPassword.Password);
		}

		private void btn_regresar_Click(object sender, RoutedEventArgs e)
		{
            var back = new PantallaPrincipal();
            back.Show();
            this.Close();
		}
		public static string Encrypt(string str)
		{
			SHA256 sha256 = SHA256Managed.Create();
			ASCIIEncoding encoding = new ASCIIEncoding();
			byte[] stream = null;
			StringBuilder sb = new StringBuilder();
			stream = sha256.ComputeHash(encoding.GetBytes(str));
			for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
			return sb.ToString();
		}

		private void BtnIngresar_Click(object sender, RoutedEventArgs e)
		{
			if (Validar())
			{
				var inicioSesion = new User
				{
					Usuario = txtUsuario.Text,
					Password = Encrypt(txtPassword.Password)
				};
				var verificar = new UserBL();
				User Logearse = verificar.Login(inicioSesion);

				if (Logearse.Usuario == inicioSesion.Usuario && Logearse.Password == inicioSesion.Password)
				{
					var formAgregar = new SelecAdministrar();
					formAgregar.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Revise las credenciales ingresadas por favor", "Error");
				}
			}
			else
			{
				MessageBox.Show("Rellene todos los campos solicitados para iniciar seesion por favor", "Error");
			}
		}

		private void txtUsuario_GotFocus(object sender, RoutedEventArgs e)
		{
			txtUsuario.Text = "";
			txtUsuario.Foreground = new SolidColorBrush(Colors.Black);
		}

		private void txtPassword_GotFocus(object sender, RoutedEventArgs e)
		{
			txtPassword.Password = "";
			txtPassword.Foreground = new SolidColorBrush(Colors.Black);
		}
	}
}
