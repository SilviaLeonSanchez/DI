using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Avituallamientos.dto
{
    public class Avituallamiento : ICloneable, INotifyPropertyChanged, IDataErrorInfo
    {
        public Avituallamiento(Carrera carrera)
        {
            totalAvituallamientos += 1;
            this.idAvituallamiento = Convert.ToString(totalAvituallamientos);
            this.idCarrera = carrera.IdCarrera;
            this.nombreCarrera = carrera.NombreCarrera;
            this.Materiales = new Dictionary<Material, int>();
        }

        public Avituallamiento(Carrera carrera, float puntoKm, string persona, string telefono)
        {
            totalAvituallamientos += 1;
            this.idAvituallamiento = Convert.ToString(totalAvituallamientos);
            this.idCarrera = carrera.IdCarrera;
            this.nombreCarrera = carrera.NombreCarrera;
            this.Materiales = new Dictionary<Material, int>();
            this.puntoKm = puntoKm;
            this.personaContacto = persona;
            this.telefonoContacto = telefono;
        }

        
        private string idCarrera;
        public string IdCarrera
        {
            get
            {
                return idCarrera;
            }
            set
            {
                idCarrera = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("IdCarrera"));
            }
        }

        private string nombreCarrera;
        public string NombreCarrera 
        { 
            get
            {
                return nombreCarrera;
            }
            set
            {
                nombreCarrera = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("NombreCarrera"));
            } 
        }

        private string idAvituallamiento;
        public string IdAvituallamiento 
        {
            get
            {
                return idAvituallamiento;
            }
            set
            {
                idAvituallamiento = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("IdAvituallamiento"));
            }
        }

        private float puntoKm;
        public float PuntoKm 
        {
            get
            {
                return puntoKm;
            }
            set
            {
                puntoKm = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("PuntoKm"));
            }
        }

        private string personaContacto;
        public string PersonaContacto 
        {
            get
            {
                return personaContacto;
            }
            set
            {
                personaContacto = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("PersonaContacto"));
            }
        }

        private string telefonoContacto;
        public string TelefonoContacto 
        {
            get
            {
                return telefonoContacto;
            }
            set
            {
                telefonoContacto = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("TelefonoContacto"));
            }
        }

        public Dictionary<Material,int> Materiales { get; set; }
        private static int totalAvituallamientos = 0;
        public event PropertyChangedEventHandler PropertyChanged;

       
        public object Clone()
        {
            return this.MemberwiseClone();
        }





        public string Error
        {
            get { return ""; }
        }

        public string this[string columnName]
        {
            get 
            {
                if (columnName == "IdCarrera")
                {
                   if (string.IsNullOrEmpty(idCarrera))
                        return "El id de la carrera no puede estar vacío";
                }
                else if (columnName == "NombreCarrera"){
                    if (string.IsNullOrEmpty(nombreCarrera))
                        return "El nombre de la carrera no puede estar vacío";
                }
                else if (columnName == "IdAvituallamiento")
                {
                    if (string.IsNullOrEmpty(idAvituallamiento))
                        return "El id del avituallamiento no puede estar vacío";
                }
                else if (columnName == "PuntoKm")
                {
                    if (puntoKm < 0)
                        return "El punto kilométrico debe ser un número positivo";
                }
                else if (columnName == "PersonaContacto")
                {
                    if (string.IsNullOrEmpty(personaContacto))
                        return "El nombre de la persona de contacto no puede estar vacío";
                }
                else if (columnName == "TelefonoContacto")
                {
                    if (string.IsNullOrEmpty(telefonoContacto))
                        return "El teléfono de la persona de contacto no puede estar vacío";
                    else if (telefonoContacto.Length != 9)
                        return "El télefono de la persona de contacto debe tener 9 digitos";
                    else
                    {
                        try
                        {
                            Convert.ToInt64(telefonoContacto);
                        }
                        catch(FormatException ex)
                        {
                            return "El teléfono de la persona de contacto debe estar formado solo por cifras";
                        }
                    }

                }

                return "";
            }
        }
    }
}
