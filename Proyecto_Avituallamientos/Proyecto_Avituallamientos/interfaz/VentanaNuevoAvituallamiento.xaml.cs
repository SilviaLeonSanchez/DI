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
        public Avituallamiento avituallamiento;
        public int posicion;

        public VentanaNuevoAvituallamiento()
        {
            InitializeComponent();
            this.avituallamiento = new Avituallamiento();
            this.posicion = -1;
            this.DataContext = this;
        }

        public VentanaNuevoAvituallamiento(Avituallamiento avituallamiento, int posicion)
        {
            InitializeComponent();
            this.avituallamiento = avituallamiento;
            this.posicion = posicion;
            this.DataContext = this;
        }


    }
}
