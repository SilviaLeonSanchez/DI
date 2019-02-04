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

namespace Proyecto_Avituallamientos.interfaz
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class VentanaMateriales : Window
    {
        public VentanaMateriales()
        {
            InitializeComponent();
        }

        private void ButtonVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonAniadirMaterial_Click(object sender, RoutedEventArgs e)
        {
            VentanaNuevoMaterial ventana = new VentanaNuevoMaterial();
            ventana.ShowDialog();
        }

    }
}
