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

        public Avituallamiento avituallamiento;

        public VentanaMateriales()
        {
            InitializeComponent();
            this.DataContext = MainWindow.Logica;
            this.ButtonAniadirMaterial.Visibility = System.Windows.Visibility.Hidden;
            this.LabelCantidad.Visibility = System.Windows.Visibility.Hidden;
            this.TextBoxCantidad.Visibility = System.Windows.Visibility.Hidden;
        }

        public VentanaMateriales(Avituallamiento avituallamiento)
        {
            InitializeComponent();
            this.avituallamiento = avituallamiento;
            this.DataContext = MainWindow.Logica;
            this.ButtonBorrarMaterial.Visibility = System.Windows.Visibility.Hidden;
            this.ButtonEditarMaterial.Visibility = System.Windows.Visibility.Hidden;
            this.ButtonNuevoMaterial.Visibility = System.Windows.Visibility.Hidden;
        }

        private void ButtonAniadirMaterial_Click(object sender, RoutedEventArgs e)
        {
            int cantidad = 0;
            if (string.IsNullOrEmpty(this.TextBoxCantidad.Text))
            {
                MessageBox.Show("Introduce una cantidad");
            }
            else
            {
                try
                {
                    cantidad = Convert.ToInt32(this.TextBoxCantidad.Text);
                    if (cantidad <= 0)
                    {
                        MessageBox.Show("La cantidad debe ser un numero entero positivo");
                    }
                    else
                    {
                        Material material = (Material)DataGridMateriales.SelectedItem;
                        if (material != null)
                        {
                            if (this.avituallamiento.Materiales.ContainsKey(material))
                            {
                                this.avituallamiento.Materiales[material] += cantidad;
                            }
                            else
                            {
                                this.avituallamiento.Materiales.Add(material, cantidad);
                            }
                            MessageBox.Show("Material añadido correctamente");
                        }
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("La cantidad debe ser un numero entero positivo");
                }

            }





            
               
            
        }

        private void ButtonBorrarMaterial_Click(object sender, RoutedEventArgs e)
        {
            Material material = (Material) DataGridMateriales.SelectedItem;
            if (material != null)
                MainWindow.Logica.ListaMateriales.Remove(material);
        }

        private void ButtonEditarMaterial_Click(object sender, RoutedEventArgs e)
        {
            Material material = (Material)DataGridMateriales.SelectedItem;
            if (material != null)
            {
                (new VentanaNuevoMaterial(material, MainWindow.Logica.ListaMateriales.IndexOf(material))).ShowDialog();
            }

        }

        private void ButtonNuevoMaterial_Click(object sender, RoutedEventArgs e)
        {
            VentanaNuevoMaterial ventana = new VentanaNuevoMaterial();
            ventana.ShowDialog();
        }


    }
}
