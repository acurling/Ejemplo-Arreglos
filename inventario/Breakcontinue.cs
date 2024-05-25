using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventario
{
    internal class Breakcontinue
    {

        public static void i_Break() { 

         
          for (int i = 0; i < 10; i++) {

                if (i==5)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            
            }

            Console.Read();
        
        }
    }
}
