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
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class VentanaNuevoMaterial : Window
    {
        public Material material_nuevo;

        public VentanaNuevoMaterial()
        {
            InitializeComponent();
        }

        private void ButtonVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonNuevoMaterial_Click(object sender, RoutedEventArgs e)
        {
            string nombre = this.TextBoxNombreMaterial.Text;
            TIPO_MATERIAL tipo = (TIPO_MATERIAL) this.ComboBoxTipoMaterial.SelectedItem;
            double precio = Convert.ToDouble(this.TextBoxPrecio.Text);
            material_nuevo = new Material(nombre, tipo, precio);
            logica.LogicaNegocio.GetInstance().ListaMateriales.Add(material_nuevo);
        }
    }
}
