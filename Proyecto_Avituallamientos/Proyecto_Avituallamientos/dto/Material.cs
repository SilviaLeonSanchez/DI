using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Avituallamientos.Modelos
{
    public class Material
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public TIPO_MATERIAL Tipo { get; set; }
        public float Precio { get; set; }

        public override string ToString()
        {
            return "Nombre: "+Nombre+"\tTipo material: "+Tipo+"\tPrecio: "+Precio;
        }

    }

    public enum TIPO_MATERIAL
    {
        BEBIDA, COMIDA, MATERIAL_SANITARIO
    }
}
