using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Avituallamientos.Modelos
{
    class Carrera
    {
        public string IdCarrera { get; set; }
        public string NombreCarrera { get; set; }
        public List<Avituallamiento> Avituallamientos { get; set; }

        public string ToString()
        {
            string info = "Id Carrera: "+IdCarrera+ "\tNombre: "+NombreCarrera;
            info += "Avituallamientos: " + (Avituallamientos.Count == 0 ? "Ninguno" : "\n");
            foreach (var avituallamiento in Avituallamientos)
            {
                info += "\tAvituallamiento: " + avituallamiento.ToString();
            }
            return info;
            }
    }
}
