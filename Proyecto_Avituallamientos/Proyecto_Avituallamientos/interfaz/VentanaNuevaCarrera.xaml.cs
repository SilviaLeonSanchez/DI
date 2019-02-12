using Proyecto_Avituallamientos.dto;
using Proyecto_Avituallamientos.logica;
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
    /// Lógica de interacción para NuevaCarrera.xaml
    /// </summary>
    public partial class VentanaNuevaCarrera : Window
    {

        public Carrera carrera { get; set; }
        public int posicion { get; set; }

        public VentanaNuevaCarrera()
        {
            InitializeComponent();
            this.DataContext = this;
            this.carrera = new Carrera();
            this.posicion = -1;
            
        }

        public VentanaNuevaCarrera(Carrera carrera, int posicion)
        {
            InitializeComponent();
            this.DataContext = this;
            this.carrera = (Carrera) carrera.Clone();
            this.posicion = posicion;
        }

        private void ButtonNuevaCarrera_Click(object sender, RoutedEventArgs e)
        {
            if (posicion == -1)
            {
                LogicaNegocio.GetInstance().ListaCarreras.Add(this.carrera);
            }
            else 
            {
                LogicaNegocio.GetInstance().ListaCarreras[this.posicion] = this.carrera;
            }
            this.Close();
        }

        private void EditarAvituallamientos_Click(object sender, RoutedEventArgs e)
        {
            int posicion_seleccionada = this.DataGridAvituallamientos.SelectedIndex;
            if (posicion_seleccionada != -1)
            {
                VentanaNuevoAvituallamiento ventana = new VentanaNuevoAvituallamiento(carrera.Avituallamientos[posicion_seleccionada], posicion_seleccionada);
                ventana.ShowDialog();
            }
        }

        private void AniadirAvituallamientos_Click(object sender, RoutedEventArgs e)
        {
            VentanaNuevoAvituallamiento ventana = new VentanaNuevoAvituallamiento();
            ventana.ShowDialog();
        }



    }
}
