using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace inventario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sistema tomar las notas de los estudiante 3, 
            // calcular el promedio de las notas de los estudiantes
            // Saber cuantos estudiantes tienen una nota superior al promedio

            // Breakcontinue.i_Break();
            // Arreglos.arreglos();

            Menu.menu();
            float calificacion = 0;
            float promedio= 0;
            byte contador =0;
            float acumulador = 0;

           // Definir el promedio de las notas
          while(contador < 3 )
            {
                Console.WriteLine("ingrese la nota del estudiante: ");
                calificacion = float.Parse(Console.ReadLine());  
                //  acumulador = acumulador + calificacion;
                acumulador += calificacion;  // acumulador
                contador++;
            }

          // calcular el promedio
          promedio = acumulador / (float)contador;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"El promedio de las notas es de {promedio}");
            Console.WriteLine("__________________________________________");
            Console.ForegroundColor = ConsoleColor.White;
            // Determinar cuantos estudiante tienen una nota superior al promedio
            contador = 0;
            acumulador = 0;
            while (contador < 3)
            {
                Console.WriteLine("ingrese la nota del estudiante: ");
                calificacion = float.Parse(Console.ReadLine());

                if (calificacion> promedio)
                {
                    acumulador++;
                }
                contador++;
            }

            Console.WriteLine($"Los estudiantes con nota mayor al promedio son: {acumulador}" );
            Console.Read();
        }
    }
}
