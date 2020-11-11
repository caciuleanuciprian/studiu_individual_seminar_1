using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiuIndividualProblema1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarare variabile
            int n, a, b, aux = 0, suma = 0, nrEl = 0;

            //Citire variabile
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] array = new int[n];

            //Stabilire interval
            if (b < a)
            {
                aux = b;
                b = a;
                a = aux;
            }

            //Citire vector
            Console.WriteLine("Elementele vectorului: ");

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > a && array[i] < b)
                {
                    suma = suma + array[i];
                    nrEl++;
                }
            }


            Console.WriteLine("Media este: " + (suma / nrEl));


            Console.ReadLine();
        }
    }
}
