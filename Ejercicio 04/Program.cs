using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Vector de 10 elementos del rango 1 al 50 suma de los elementos");
            Console.WriteLine(" ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int[] numero = new int[10];
            int suma = 0;
            Console.WriteLine();
            for (int i = 0; i < numero.Length; i++)
            {
                Console.Write($" Ingresar {i+1}° numero = ");
                numero[i] = Int32.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine();
            Console.Write(" Numero = [");
            for (int i = 0; i < numero.Length; i++)
            {
                if (i < numero.Length - 1)
                {
                    Console.Write($" {numero[i]}, ");
                }
                else
                {
                    Console.Write($" {numero[i]} ");
                }
                suma += numero[i];
            }
            Console.WriteLine("] ");
            Console.WriteLine();
            Console.WriteLine($" Sumas = {suma}");

            Console.WriteLine();
            Console.WriteLine("****************");
            Console.WriteLine(" Fin del Proceso");
            Console.WriteLine("****************");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
