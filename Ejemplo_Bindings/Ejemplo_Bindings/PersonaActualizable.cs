using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Bindings
{
    public class PersonaActualizable : INotifyPropertyChanged
    {
        private string nombre;
        private string apellido;

        public string Nombre;
        public string Apellido;

            public PersonaActualizable(string nombre, string apellido)
            {
                this.nombre = nombre;
                this.apellido = apellido;
            }


            public override string ToString()
            {
                return Nombre + " " + Apellido;
            }

        public event PropertyChangedEventHandler PropertyChanged;

        
    }
}
