﻿using Fablab.esfe;
using System;
using System.Collections.Generic;
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

namespace interfaces
{
    /// <summary>
    /// Lógica de interacción para MantenimientoMaquinaria.xaml
    /// </summary>
    public partial class MantenimientoMaquinaria : Window
    {
        public MantenimientoMaquinaria()
        {
            InitializeComponent();
        }

		private void btnIngresar_Click(object sender, RoutedEventArgs e)
		{
            var ScAdd = new IngresarMaquinaria();
            ScAdd.Show();
            this.Close();
        }

		private void btnModificar_Click(object sender, RoutedEventArgs e)
		{
            var ScModi = new EliminarMaquinaria();
            ScModi.Show();
            this.Close();
		}

		private void btnRegresar_Click(object sender, RoutedEventArgs e)
		{
            var ScBack = new SelecAdministrar();
            ScBack.Show();
            this.Close();
		}
	}
}
