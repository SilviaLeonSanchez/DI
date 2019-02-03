using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Avituallamientos.Modelos
{
    class Material
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public TIPO_MATERIAL Tipo { get; set; }
        public float Precio { get; set; }

        public string ToString()
        {
            return "Nombre: "+Nombre+"\tTipo material: "+Tipo+"\tPrecio: "+Precio;
        }

    }

    enum TIPO_MATERIAL
    {
        BEBIDA, COMIDA, MATERIAL_SANITARIO
    }
}
