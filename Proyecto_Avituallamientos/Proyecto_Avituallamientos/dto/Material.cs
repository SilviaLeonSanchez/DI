using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Avituallamientos.dto
{
    public class Material
    {
        private static int UltimoId;
        public string Id { get; set; }
        public string Nombre { get; set; }
        public TIPO_MATERIAL Tipo { get; set; }
        public double Precio { get; set; }

        public Material(string nombre, TIPO_MATERIAL tipo, double precio)
        {
            this.Id = UltimoId + "";
            UltimoId++;
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Precio = precio;
        }

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
