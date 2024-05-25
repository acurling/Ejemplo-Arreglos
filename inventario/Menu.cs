using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventario
{


    internal class Menu
    {

        static int opcion = 0;
        static string[] cedula = new string[10];
        static int[] edad = new int[10];
        static int x = 0;
        public static void menu()
        {

            do
            {
                Console.WriteLine("1- Agregar persona");
                Console.WriteLine("2- Imprimir persona");
                Console.WriteLine("3- Consultar persona");
                Console.WriteLine("4- salir");
                Console.WriteLine("Digite una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1: AgregarPersona();
                        break;
                    case 2: imprimir(); break;
                    case 3: consultar();  break;
                    case 4: break;
                }

            } while (opcion != 3);
            Console.WriteLine("Salio del menu");
        }

        public static void consultar()
        {
            Console.WriteLine("Ingrese una cedula: ");
            string id = Console.ReadLine();

            for (int i = 0; i < cedula.Length; i++)
            {
                
                if (id.Equals(cedula[i]))
                {
                    Console.WriteLine($"La edad de usuario {cedula[i]} es de {edad[i]}");
                    break;
                }
            }
        }

        public static void imprimir() {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***** LISTA DE PERSONAS ****** ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < x; i++)
            {
                Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine($"Cedula: {cedula[i]}  Edad: {edad[i]}");
            }
        
        }   
        public static void AgregarPersona()
        {
            string opcion = "";
            do
            {

                Console.WriteLine("Solicite la cedula: ");
                cedula[x] = Console.ReadLine();
                Console.WriteLine("Solicite la edad: ");
                edad[x] = int.Parse(Console.ReadLine());
                x++;
                Console.WriteLine("Desea continuar (s/n)");
                opcion = Console.ReadLine().ToLower(); // tolower convierte todo a minuscula  // toupper pasar mayuscala

            } while (!opcion.Equals("n"));
        }
    }
}
