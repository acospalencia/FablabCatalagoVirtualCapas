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
    public partial class ActualizarMateriales : Form
    {
        public ActualizarMateriales()
        {
            InitializeComponent();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Seleccionar imagen";
			openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
				string rutaImagen = openFileDialog.FileName;

				try
				{
					// Cargar la imagen en el PictureBox
					pictureBox2.Image = Image.FromFile(rutaImagen);

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al cargar la imagen: " + ex.Message);
				}
			}
        }
	}
}
