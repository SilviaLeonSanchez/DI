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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ejemplo_Bindings
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ObservableCollection<Persona> ListaPersonas {get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
           
            ListaPersonas = new ObservableCollection<Persona>();
            ListaPersonas.Add(new Persona("Pedro", "Ramirez"));
            ListaPersonas.Add(new Persona("Juan", "Fernandez"));
            ListaPersonas.Add(new Persona("Maria", "Cano"));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PruebaGrid ventana = new PruebaGrid();
            ventana.ShowDialog();
        }
    }

    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }

    }
}
