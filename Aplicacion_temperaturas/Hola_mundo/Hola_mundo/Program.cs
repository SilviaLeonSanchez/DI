using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola_mundo
{
    class Program
    {
        // VARIABLES
        static List<double>[] meses;
        static String[] nombre_meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

        // METODOS
        static void FormatearSalida(int x, int y)
        {
            Console.WriteLine("x = {0}, y = {1}", x, y);
        }
        
        static byte Menu()
        {
            String menu =
                "\n~~~~ MENU ~~~~\n" +
                "1. Insertar temperatura\n"+
                "2. Ver temperaturas\n"+
                "3. Ver media temperaturas\n"+
                "4. Salir\n\n";
            Console.Write(menu);
            byte opcion = 0;
            do{
                try
                {
                    Console.Write("Introduce el numero de opcion: ");
                    opcion = Convert.ToByte(Console.ReadLine());
                    if (opcion == 4)
                    {
                        return 0;
                    }
                    else if (opcion < 1 || opcion > 3)
                    {
                        throw new Exception();
                    }
                }catch(Exception ex)
                {
                    opcion = 0;
                    Console.WriteLine("\nTiene que ser un numero entre 1 y 4");
                }
            } while (opcion == 0);
            return opcion;
        }

        static byte MenuMeses()
        {
            String menu =
                "\n\t~~~~ MESES ~~~~\n" +
                "\t1. Enero\n" +
                "\t2. Febrero\n" +
                "\t3. Marzo\n" +
                "\t4. Abril\n"+
                "\t5. Mayo\n" +
                "\t6. Junio\n" +
                "\t7. Julio\n" +
                "\t8. Agosto\n" +
                "\t9. Septiembre\n" +
                "\t10. Octubre\n" +
                "\t11. Noviembre\n" +
                "\t12. Diciembre\n"+
                "\t13. Salir\n\n";
            Console.Write(menu);
            byte opcion = 0;
            do
            {
                try
                {
                    Console.Write("Introduce el numero del mes: ");
                    opcion = Convert.ToByte(Console.ReadLine());
                    if (opcion == 13)
                    {
                        return opcion;
                    }
                    else if (opcion < 1 || opcion > 13)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    opcion = 0;
                    Console.WriteLine("\nTiene que ser un numero entre 1 y 13");
                }
            } while (opcion == 0);
            return (--opcion);
        }

        static void InicializarMeses()
        {
            meses = new List<double>[12];
            for (int i = 0; i < 12; i++)
            {
                meses[i] = new List<double>();
            }
        }

        static void VerTemperaturas()
        {
            Console.WriteLine();
            for (int i = 0; i < meses.Length; i++)
            {
                Console.WriteLine(nombre_meses[i] + ": " + meses[i].Count);
                foreach (var temperatura in meses[i])
                {
                    Console.WriteLine("\t" + temperatura + "º C");
                }
            }
        }

        static void VerTemperaturaMedia(int mes)
        {
            if (meses[mes].Count == 0)
            {
                Console.WriteLine(nombre_meses[mes] + " no tiene ninguna temperatura aun");
            }
            else
            {
                Console.WriteLine(nombre_meses[mes] + ": " + meses[mes].Average() + "º C de media");
            }
        }

        static void InsertarTemperatura(byte mes)
        {
            Console.Write("Introduce la nueva temperatura: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            meses[mes].Add(temp);
            Console.WriteLine("\nTemperatura añadida a la coleccion");
        }


        // EJECUCION
        static void Main(string[] args)
        {
            InicializarMeses();
            
            byte opcion = 0;
            do
            {
                opcion = Menu();
                switch (opcion)
                {
                    case 1:
                        byte mes = MenuMeses();
                        if (mes != 13)
                        {
                            InsertarTemperatura(mes);
                        }
                        break;
                    case 2:
                        VerTemperaturas();
                        break;
                    case 3:
                        mes = MenuMeses();
                        if (mes != 13)
                        {
                            VerTemperaturaMedia(mes);
                        }
                        break;
                }
            } while (opcion != 0);
            Console.WriteLine("\n¡Hasta pronto!");
        }
    }
}
