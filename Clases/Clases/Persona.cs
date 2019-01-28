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
        



        // METODOS
        public void VerDatos()
        {
            Console.WriteLine("Nombre: {0} \tApellidos: {1} \tEdad: {2}\n", this.Nombre, this.Apellidos, this.Edad);
        }

        public void LeerDatos()
        {
            bool ok = false;

            while (!ok)
            {
                try
                {
                    Console.Write("Introduce el nombre: ");
                    this.Nombre = Console.ReadLine();
                    Console.Write("Introduce los apellidos: ");
                    this.Apellidos = Console.ReadLine();
                    Console.Write("Introduce la edad: ");
                    this.Edad = Convert.ToByte(Console.ReadLine());
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
