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
        public ObservableCollection<Carrera> ListaCarreras { get; set; }

        public VentanaCarreras()
        {
            InitializeComponent();
            this.ListaCarreras = LogicaNegocio.GetInstance().ListaCarreras;
            this.DataContext = this;
        }

        private void DataGridCarreras_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            VentanaAvituallamientos ventana = new VentanaAvituallamientos();
            ventana.ShowDialog();
        }
    }
}
