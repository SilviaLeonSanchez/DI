using Proyecto_Avituallamientos.dto;
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
    /// Lógica de interacción para Window4.xaml
    /// </summary>
    public partial class VentanaNuevoAvituallamiento : Window
    {
        public Carrera carrera { get; set; }
        public Avituallamiento avituallamiento { get; set; }
        public int posicion;
        public Material[] Material { get; set; }

        public VentanaNuevoAvituallamiento(Carrera carrera)
        {
            InitializeComponent();
            this.avituallamiento = new Avituallamiento(carrera);
            this.Material = avituallamiento.Materiales.Keys.ToArray();
            this.DataContext = this;
            this.posicion = -1;
            this.carrera = carrera;
            this.TextBoxNombreCarrera.IsEnabled = false;
        }

        public VentanaNuevoAvituallamiento(Carrera carrera, Avituallamiento avituallamiento, int posicion)
        {
            InitializeComponent();
            this.avituallamiento = (Avituallamiento) avituallamiento.Clone();
            this.DataContext = this;
            this.posicion = posicion;
            this.carrera = carrera;
            this.TextBoxNombreCarrera.IsEnabled = false;
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
            VentanaMateriales ventana = new VentanaMateriales(this.avituallamiento);
            ventana.ShowDialog();
        }

        private void ButtonBorrarMaterial_Click(object sender, RoutedEventArgs e)
        {
         // int posicion = this.DataGridMaterial.
           
        }


    }
}
