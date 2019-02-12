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


        public VentanaMateriales()
        {
            InitializeComponent();
            this.DataContext = LogicaNegocio.GetInstance();
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

        private void ButtonBorrarMaterial_Click(object sender, RoutedEventArgs e)
        {
            int posicion = DataGridMateriales.SelectedIndex;
            if (posicion != -1)
                LogicaNegocio.GetInstance().ListaMateriales.RemoveAt(posicion);
        }

        private void ButtonEditarMaterial_Click(object sender, RoutedEventArgs e)
        {
            int posicion = DataGridMateriales.SelectedIndex;
            if (posicion != -1)
                (new VentanaNuevoMaterial((Material)DataGridMateriales.SelectedItem, DataGridMateriales.SelectedIndex)).ShowDialog();

        }


    }
}
