using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Persona
    {
        // FORMA LARGA
        
        private string nombre;
        private string apellidos;
        private byte edad;

        /*
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public byte Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        */


        // FORMA CORTA
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public byte Edad { get; set; }


        // METODOS
        public void VerDatos()
        {
            Console.WriteLine("Nombre: {0} \tApellidos: {1} \tEdad: {2}\n", nombre, apellidos, edad);
        }

        public void LeerDatos()
        {
            bool ok = false;

            while (!ok)
            {
                try
                {
                    Console.Write("Introduce el nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Introduce los apellidos: ");
                    apellidos = Console.ReadLine();
                    Console.Write("Introduce la edad: ");
                    edad = Convert.ToByte(Console.ReadLine());
                    ok = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine("Introduce los datos otra vez");
                }
            }
        }
    }
}
