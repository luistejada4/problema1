using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdusca una oracion para contar las palabras!");
            String oracion = Console.ReadLine();
            oracion.Trim();
            int palabras = 0, index = 0;

            while (index < oracion.Length)
            {
                while (index < oracion.Length && !char.IsWhiteSpace(oracion[index]))
                    index++;

                palabras++;

                while (index < oracion.Length && char.IsWhiteSpace(oracion[index]))
                    index++;
            }
            Console.WriteLine("Tiene {0}", palabras);
            Console.ReadKey();
        }
    }
}
