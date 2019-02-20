using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Avituallamientos.dto;

namespace Proyecto_Avituallamientos.logica
{
    public class LogicaNegocio
    {
        // ATRIBUTOS
        public ObservableCollection<Carrera> ListaCarreras { get; set; }
        public ObservableCollection<Material> ListaMateriales {get; set;}
        public ObservableCollection<String> TipoMaterial { get; set; }

        // METODOS 
        public LogicaNegocio()
        {
            ListaMateriales = new ObservableCollection<Material>();
            ListaCarreras = new ObservableCollection<Carrera>();
            TipoMaterial = new ObservableCollection<String>();

            // TIPO DE MATERIAL
            TipoMaterial.Add("Bebida"); 
            TipoMaterial.Add("Comida");
            TipoMaterial.Add("Material sanitario");

            // LISTA DE MATERIALES
            ListaMateriales.Add(new Material("Redbull",TipoMaterial[0], 2.00));
            ListaMateriales.Add(new Material("Panchitos", TipoMaterial[1], 1.50));

            // CARRERAS
            Carrera carrera = new Carrera("Carrera de prueba");
            Avituallamiento av = new Avituallamiento(carrera, 10, "Soraya Saez", "652451254");
            carrera.Avituallamientos.Add(av);
            ListaCarreras.Add(carrera);
        }

    }
      
}
