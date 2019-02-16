using Proyecto_Avituallamientos.dto;
using Proyecto_Avituallamientos.logica;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Proyecto_Avituallamientos.interfaz
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class VentanaMateriales : Window
    {

        public Avituallamiento avituallamiento;

        public VentanaMateriales()
        {
            InitializeComponent();
            this.DataContext = MainWindow.Logica.ListaMateriales;
        }

        public VentanaMateriales(Avituallamiento avituallamiento)
        {
            InitializeComponent();
            this.avituallamiento = avituallamiento;
            this.DataContext = avituallamiento;
        }

        private void ButtonAniadirMaterial_Click(object sender, RoutedEventArgs e)
        {
            VentanaNuevoMaterial ventana = new VentanaNuevoMaterial();
            ventana.ShowDialog();
        }

        private void ButtonBorrarMaterial_Click(object sender, RoutedEventArgs e)
        {
            int posicion = DataGridMateriales.SelectedIndex;
            if (posicion != -1)
                MainWindow.Logica.ListaMateriales.RemoveAt(posicion);
        }

        private void ButtonEditarMaterial_Click(object sender, RoutedEventArgs e)
        {
            int posicion = DataGridMateriales.SelectedIndex;
            if (posicion != -1)
                (new VentanaNuevoMaterial((Material)DataGridMateriales.SelectedItem, DataGridMateriales.SelectedIndex)).ShowDialog();

        }


    }
}
