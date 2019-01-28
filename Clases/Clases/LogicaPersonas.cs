using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class LogicaPersonas
    {
        private List<Persona> personas;
        public List<Persona> Personas
        {
            get
            {
                return personas;
            }
        }

        public LogicaPersonas()
        {
            this.personas = new List<Persona>();
        }


        // METODOS
        private byte Menu()
        {
            int opcionSalir = 4;
            String menu =
                "\n~~~~ MENU ~~~~\n" +
                "1. Insertar persona\n" +
                "2. Ver personas\n" +
                "3. Borrar persona\n" +
                opcionSalir +". Salir\n\n";
            Console.Write(menu);
            byte opcion = 0;
            do
            {
                try
                {
                    Console.Write("Introduce el numero de opcion: ");
                    opcion = Convert.ToByte(Console.ReadLine());
                    if (opcion == opcionSalir)
                    {
                        return 0;
                    }
                    else if (opcion < 1 || opcion > opcionSalir)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    opcion = 0;
                    Console.WriteLine("\nTiene que ser un numero entre 1 y "+opcionSalir);
                }
            } while (opcion == 0);
            return opcion;
        }

        public void VerPersonas()
        {
            Console.WriteLine();
            foreach (Persona p in this.Personas)
            {
                p.VerDatos();
            }
            if (this.personas.Count == 0)
            {
                Console.WriteLine("No hay ninguna persona en la lista");
            }
        }

        public void InsertarPersona()
        {
            Persona p = new Persona();
            p.LeerDatos();
            this.personas.Add(p);
        }

        public void BorrarPersonas()
        {
            Console.Write("Introduce el nombre de la persona: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduce los apellidos de la persona: ");
            string apellidos = Console.ReadLine();

            int borrados = personas.RemoveAll(p => (p.Nombre == nombre && p.Apellidos == apellidos) );

            Console.WriteLine("Se han borrado {0} personas de la lista", borrados);
        }

        public void Ejecutar()
        {
            byte opcion = 0;
            do
            {
                opcion = Menu();
                switch (opcion)
                {
                    case 1:
                        InsertarPersona();
                        break;
                    case 2:
                        VerPersonas();
                        break;
                    case 3:
                        BorrarPersonas();
                        break;
                    case 4:
                        opcion = 0;
                        break;
                }
            } while (opcion != 0);
            Console.WriteLine("\n¡Hasta pronto!");
        }
    }
}
