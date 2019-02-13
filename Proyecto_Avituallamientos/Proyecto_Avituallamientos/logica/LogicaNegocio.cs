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
        public static ObservableCollection<Carrera> ListaCarreras { get; set; }
        public static ObservableCollection<Material> ListaMateriales {get; set;}
        public static ObservableCollection<String> TipoMaterial { get; set; }

        // METODOS 
        public LogicaNegocio()
        {
            ListaMateriales = new ObservableCollection<Material>();
            ListaCarreras = new ObservableCollection<Carrera>();
            TipoMaterial = new ObservableCollection<String>();
            TipoMaterial.Add("Bebida"); 
            TipoMaterial.Add("Comida");
            TipoMaterial.Add("Material sanitario");

            ListaMateriales.Add(new Material("Redbull",TipoMaterial[0], 2.00));
            ListaMateriales.Add(new Material("Panchitos", TipoMaterial[1], 1.50));

            ListaCarreras.Add(new Carrera("Carrera de prueba"));
        }

        public void AddMaterial(Material material)
        {
            ListaMateriales.Add(material);
        }

        public void AddCarrera(Carrera carrera)
        {
            ListaCarreras.Add(carrera);
        }

        public Carrera buscarCarrera(string nombre)
        {
            foreach (Carrera c in ListaCarreras)
            {
                if (c.NombreCarrera==nombre)
                {
                    return c;
                }
            }
            return null;
        
        }


    }
        }
