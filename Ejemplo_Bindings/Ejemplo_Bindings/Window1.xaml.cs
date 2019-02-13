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

namespace Ejemplo_Bindings
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Persona Persona { get; set; }
        private int numErrores = 0;

        public Window1()
        {
            InitializeComponent();
            this.Persona = new Persona("Silvia", "Leon");
            this.DataContext = this;
        }

        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {

            if (e.Action == ValidationErrorEventAction.Added)
            {
                numErrores++;

                // Para que salga el mensaje del error
                ((Control)sender).ToolTip = e.Error.ErrorContent;
            }
            else if (e.Action == ValidationErrorEventAction.Removed)
            {
                numErrores--;
                // Para quitar el mensaje del error
                ((Control)sender).ToolTip = null;
            }
                BotonAceptar.IsEnabled = (numErrores == 0);
            
                       
        }
    }
}
