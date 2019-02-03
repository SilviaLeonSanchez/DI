﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Avituallamientos
{
    class Avituallamiento
    {
        public string IdCarrera { get; set; }
        public string NombreCarrera { get; set; }

        public string IdAvituallamiento { get; set; }
        public float PuntoKm { get; set; }
        public string PersonaContacto { get; set; }
        public string TelefonoContacto { get; set; }
        public Dictionary<string,int> Materiales { get; set; }

        public string ToString()
        {
            string info = "Carrera: " + NombreCarrera + "\tId Carrera: " + IdCarrera + "\tPunto kilometrico: " + PuntoKm + "\tId Avituallamiento: " + IdAvituallamiento + "\tPersona Contacto: " + PersonaContacto + "\tTelefono contacto: " + TelefonoContacto + "\n";
            info += "\tMateriales: "+(Materiales.Count==0?"Ninguno":"\n");
            foreach (var material in Materiales)
            {
               info += "\t"+ material.ToString() + "\n";
            }
            return info;
        }



    }
}
