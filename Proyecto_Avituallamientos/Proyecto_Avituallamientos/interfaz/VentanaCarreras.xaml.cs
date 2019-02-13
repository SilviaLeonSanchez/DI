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
    /// Lógica de interacción para Window5.xaml
    /// </summary>
    public partial class VentanaCarreras : Window
    {

        public VentanaCarreras()
        {
            InitializeComponent();
            this.DataContext = LogicaNegocio.ListaCarreras;
        }

        private void ButtonAniadirCarrera_Click(object sender, RoutedEventArgs e)
        {
            VentanaNuevaCarrera ventana = new VentanaNuevaCarrera();
            ventana.ShowDialog();
        }

        private void ButtonBorrarCarrera_Click(object sender, RoutedEventArgs e)
        {
            int posicion_seleccionada = this.DataGridCarreras.SelectedIndex;
            if (posicion_seleccionada != -1)
            {
                MessageBoxResult resultado = MessageBox.Show(this, "¿Seguro que quieres borrar la carrera seleccionada?");
                if (resultado == MessageBoxResult.OK || resultado == MessageBoxResult.Yes)
                {
                    LogicaNegocio.ListaCarreras.RemoveAt(posicion_seleccionada);
                }
                else
                {
                    MessageBox.Show(this, "No se ha borrdo ninguna carrera");
                }
            }
        }

        private void DataGridCarreras_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            VentanaNuevaCarrera ventana = new VentanaNuevaCarrera(LogicaNegocio.ListaCarreras[this.DataGridCarreras.SelectedIndex], this.DataGridCarreras.SelectedIndex);
            ventana.ShowDialog();
        }

        private void ButtonEditarCarrera_Click(object sender, RoutedEventArgs e)
        {
            int posicion_seleccionada = this.DataGridCarreras.SelectedIndex;
            if (posicion_seleccionada != -1)
            {
                VentanaNuevaCarrera ventana = new VentanaNuevaCarrera(LogicaNegocio.ListaCarreras[this.DataGridCarreras.SelectedIndex], posicion_seleccionada);
                ventana.ShowDialog();
            }
        }
    }
}
