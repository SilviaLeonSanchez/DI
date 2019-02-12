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
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class VentanaNuevoMaterial : Window
    {
        private int posicion = -1;
        public Material nuevo_material {get; set;}
        public ObservableCollection<string> TipoMaterial {get; set; }

        public VentanaNuevoMaterial()
        {
            InitializeComponent();
            this.TipoMaterial = LogicaNegocio.GetInstance().TipoMaterial;
            this.nuevo_material = new Material();
            this.DataContext = this;
            
        }
        public VentanaNuevoMaterial(Material material, int posicion)
        {
            InitializeComponent();
            this.TipoMaterial = LogicaNegocio.GetInstance().TipoMaterial;
            this.nuevo_material = (Material) material.Clone();
            this.posicion = posicion;
            this.DataContext = this;
        }

        private void ButtonVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonNuevoMaterial_Click(object sender, RoutedEventArgs e)
        {
            if (posicion == -1)
                LogicaNegocio.GetInstance().ListaMateriales.Add(nuevo_material);
            else
                LogicaNegocio.GetInstance().ListaMateriales[posicion] = this.nuevo_material;

           this.Close();
        }
    }
}
