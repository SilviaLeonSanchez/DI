using Proyecto_Avituallamientos.dto;
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
    /// Lógica de interacción para Window4.xaml
    /// </summary>
    public partial class VentanaNuevoAvituallamiento : Window
    {
        public Carrera carrera;
        public Avituallamiento avituallamiento;
        public int posicion;

        public VentanaNuevoAvituallamiento(Carrera carrera)
        {
            InitializeComponent();
            this.carrera = carrera;
            this.TextBoxNombreCarrera.Text = carrera.NombreCarrera;
            this.avituallamiento = new Avituallamiento(carrera);
            this.TextBoxNombreCarrera.IsEnabled = false;
            this.posicion = -1;
            this.DataContext = this.avituallamiento;
        }

        public VentanaNuevoAvituallamiento(Carrera carrera, Avituallamiento avituallamiento, int posicion)
        {
            InitializeComponent();
            this.avituallamiento = avituallamiento;
            this.DataContext = this.avituallamiento;
            this.posicion = posicion;
            this.carrera = carrera;
            this.TextBoxNombreCarrera.Text = carrera.NombreCarrera;
        }

        private void ButtonGuardarAvituallamiento_Click(object sender, RoutedEventArgs e)
        {
            if (this.posicion != -1)
            {
                this.carrera.Avituallamientos[posicion] = this.avituallamiento;
            }
            else
            {
                this.carrera.Avituallamientos.Add(this.avituallamiento);
            }
            this.Close();
        }

        private void EditarMaterial_Click(object sender, RoutedEventArgs e)
        {
            VentanaMateriales ventana = new VentanaMateriales();
            ventana.ShowDialog();
        }

        private void ButtonAñadirMaterial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonBorrarMaterial_Click(object sender, RoutedEventArgs e)
        {
          // int posicion = this.DataGridMaterial.
           
        }


    }
}
