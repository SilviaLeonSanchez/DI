using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Avituallamientos.dto
{
    public class Carrera : ICloneable
    {
        private static int UltimoId;
        public string IdCarrera { get; set; }
        public string NombreCarrera { get; set; }
        public ObservableCollection<Avituallamiento> Avituallamientos { get; set; }

        public Carrera(string nombre)
        {
            this.IdCarrera = UltimoId + "";
            UltimoId++;
            this.NombreCarrera = nombre;
            this.Avituallamientos = new ObservableCollection<Avituallamiento>();
        }

        public Carrera()
        {
            this.IdCarrera = UltimoId + "";
            UltimoId++;
        }

        public override string ToString()
        {
            string info = "Id Carrera: "+IdCarrera+ "\tNombre: "+NombreCarrera;
            info += "Avituallamientos: " + (Avituallamientos.Count == 0 ? "Ninguno" : "\n");
            foreach (var avituallamiento in Avituallamientos)
            {
                info += "\tAvituallamiento: " + avituallamiento.ToString();
            }
            return info;
            }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
