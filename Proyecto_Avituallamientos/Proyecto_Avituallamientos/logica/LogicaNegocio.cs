using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Avituallamientos.dto;

namespace Proyecto_Avituallamientos.logica
{
    class LogicaNegocio
    {
        // ATRIBUTOS
        public ObservableCollection<Carrera> ListaCarreras { get; set; }
        public ObservableCollection<Material> ListaMateriales {get; set;}

        

        // SINGLETON
        private static LogicaNegocio INSTANCE;
        public static LogicaNegocio GetInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new LogicaNegocio();
            }
            return INSTANCE;
        }
        private LogicaNegocio()
        {
            ListaMateriales = new ObservableCollection<Material>();
            ListaCarreras = new ObservableCollection<Carrera>();

            ListaMateriales.Add(new Material("Redbull",TIPO_MATERIAL.BEBIDA, 2.00));
            ListaMateriales.Add(new Material("Panchitos",TIPO_MATERIAL.COMIDA, 1.50));
        }

        // METODOS 
        public void AddMaterial(Material material)
        {
            ListaMateriales.Add(material);
        }

        public void AddCarrera(Carrera carrera)
        {
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
