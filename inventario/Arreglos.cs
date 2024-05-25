using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace inventario
{
    internal class Arreglos
    {

        public static void arreglos()
        {


            string[] cedula = new string[10];
            int[] edad = new int[10];

            string opcion = "s";
            int x = 0;

            




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

            Console.WriteLine("Valor de x es {0}", x);

            Console.WriteLine(cedula.Length);

            int[] numeros = new int[100];
            numeros[0] = 20;
            numeros[1] = 15;
            numeros[2] = 30;
            Console.WriteLine(numeros.Length);
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            string[] musicos = new string[100];
            musicos[0] = "Ringo";
            musicos[1] = "George";
            musicos[2] = "Paul";
            musicos[3] = "Jonh";

            Console.WriteLine("digite un nombre:");
            musicos[0] = Console.ReadLine();

            foreach (var musico in musicos)
            {
                Console.WriteLine("Nombre: {0}", musico);
            }

            //int indice = 0;
            //while (indice <4) {
            //    Console.WriteLine(musicos[indice]);
            //    indice++;
            //}

            // ingresar datos
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("digite un nombre:");
                musicos[i] = Console.ReadLine();
                
            }

            //imprimir datos
            for (int i = 0; i < 4; i++)
            {

                Console.WriteLine(musicos[i]);

            }
            Console.ReadLine();

        }
    }
}
