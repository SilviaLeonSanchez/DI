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
    /// Lógica de interacción para Avituallamientos.xaml
    /// </summary>
    public partial class VentanaAvituallamientos : Window
    {
        public Carrera Carrera {get; set;}

        public VentanaAvituallamientos(Carrera carrera)
        {
            this.Carrera = carrera;
            
            InitializeComponent();
            this.DataContext = this.Carrera;
        }
    }
}
