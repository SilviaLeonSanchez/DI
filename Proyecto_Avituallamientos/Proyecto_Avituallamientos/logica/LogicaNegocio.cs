using Proyecto_Avituallamientos.Modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Avituallamientos.logica
{
    class LogicaNegocio
    {

        public ObservableCollection<Carrera> Carreras { get; set; }
        public ObservableCollection<Material> Materiales {get; set;}
        public static LogicaNegocio INSTANCE;

        public static LogicaNegocio getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new LogicaNegocio();
            }
            return INSTANCE;
        }

        private LogicaNegocio()
        {
            Materiales = new ObservableCollection<Material>();
            Carreras = new ObservableCollection<Carrera>();
        }


    }
}
