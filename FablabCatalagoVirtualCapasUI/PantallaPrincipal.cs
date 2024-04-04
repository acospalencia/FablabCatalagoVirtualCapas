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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

		private void btnIngresar_Click(object sender, EventArgs e)
        {
            var formLogin = new Login();
            formLogin.Show();
            this.Hide();
		}

		private void PantallaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }
    }
}
