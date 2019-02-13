using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Bindings
{
    public class PersonaActualizable : INotifyPropertyChanged, IDataErrorInfo
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




        public string Error
        {
            get { return ""; }
        }

        public string this[string columnName]
        {
            // Llama al metodo para cada campo
            // Si devuelves un string vacio entiende que no hay ningun error
            get 
            {
                string resultado = "";
                if (string.IsNullOrEmpty(columnName))
                    resultado = "Error: El campo "+ columnName +" no puede estar vacío";
                
                switch (columnName) 
                {
                    case "Nombre":
                        
                        break;
                    case "Apellido":

                        break;
                }

                return resultado;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
