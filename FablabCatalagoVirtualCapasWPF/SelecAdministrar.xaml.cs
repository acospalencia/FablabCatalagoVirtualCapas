using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasEN;
using FablabCatalagoVirtualCapasWPF;
using interfaces;
using MahApps.Metro.Controls;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
using UI;

namespace Fablab.esfe
{
    /// <summary>
    /// Lógica de interacción para SelecAdministrar.xaml
    /// </summary>
    public partial class SelecAdministrar : MetroWindow
    {
        public SelecAdministrar()
        {
            InitializeComponent();
        }

		private void btnMaterial_Click(object sender, RoutedEventArgs e)
		{
            var ScMat = new Accion_Material();
            ScMat.Show();
            this.Close();
        }

		private void btn_regresar_Click(object sender, RoutedEventArgs e)
		{
            var ScMain = new PantallaPrincipal();
            ScMain.Show();
            this.Close();
		}

		private void btnProto_CLick(object sender, RoutedEventArgs e)
		{
            var ScProto = new RegistrarPrototipos();
            ScProto.Show();
            this.Close();
        }

		private void btnUsuarios_Click(object sender, RoutedEventArgs e)
		{
            var ScUsu = new AccionUsuarios();
			ScUsu.Show();
            this.Close();
        }

		private void btnMaquinaria_Click(object sender, RoutedEventArgs e)
		{
            var ScMaq = new MantenimientoMaquinaria();
            ScMaq.Show();
            this.Close();
		}

		private void btnProveedor_Click(object sender, RoutedEventArgs e)
		{
            var ScProve = new Registrar_Proveedor();
            ScProve.Show();
            this.Close();
		}

		private void btnAutores_Click(object sender, RoutedEventArgs e)
		{
            var ScAutor = new MantenimientoAutores();
            ScAutor.Show();
            this.Close();
		}

		private void btnClubs_Click(object sender, RoutedEventArgs e)
		{
            var ScClubs = new MantenimientoClubs();
            ScClubs.Show();
            this.Close();
		}

		private void btnReportes_Click(object sender, RoutedEventArgs e)
		{
			var repo = new ReporteBL();
			var reporte = repo.RegresarLista();
			string rutaArchivo = "Reporte.pdf";
			ExportarReporteAPdf(reporte, rutaArchivo);
			MessageBox.Show("Reporte generado y guardado como PDF.");
		}
		public void ExportarReporteAPdf(List<Reporte> reporte, string rutaArchivo)
		{
			PdfDocument document = new PdfDocument();
			document.Info.Title = "Reporte de Prototipos por Autor";

			PdfPage page = document.AddPage();
			XGraphics gfx = XGraphics.FromPdfPage(page);
			XFont font = new XFont("Verdana", 12);

			gfx.DrawString("Reporte de Prototipos por Autor", font, XBrushes.Black, new XRect(0, 0, page.Width, 50), XStringFormats.TopCenter);

			int yPosition = 50;

			foreach (var item in reporte)
			{
				yPosition += 20;
				gfx.DrawString($"Autor: {item.Autor}, Prototipos: {item.CantidadPrototipos}", font, XBrushes.Black, new XRect(20, yPosition, page.Width, 50), XStringFormats.TopLeft);
			}

			document.Save(rutaArchivo);
			Process.Start(new ProcessStartInfo(rutaArchivo) { UseShellExecute = true });
		}

		private void btnSolic_Click(object sender, RoutedEventArgs e)
		{
			var ScClubs = new EliminarSolicitud();
			ScClubs.Show();
			this.Close();
		}
    }
}
