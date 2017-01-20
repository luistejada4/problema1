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
            ArrayList notas = new ArrayList();
            notas.Add(80);
            notas.Add(95);
            notas.Add(90);
            notas.Add(70);
            notas.Add(75);

            int maxNota = 0;
            int totalNotas = 0;

            foreach (int nota in notas)
            {
                if(nota > maxNota)
                {
                    maxNota = nota;
                }
                totalNotas += nota;
            }
            Console.WriteLine("La nota mayor es: {0} y la nota minima: {1}", maxNota, totalNotas/notas.Count);
            Console.ReadKey();
        }
    }
}
