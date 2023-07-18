using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Mostrar el menor valor y mayor valor del vector");
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int[] numeros = new int[5];
            int max = 0;
            int min = 0;
            max = int.MinValue;
            min = int.MaxValue;
            Console.WriteLine();
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($" Ingresar {i+1}° numero = ");
                numeros[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write(" numeros = [");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($" {numeros[i]} ");
                if (numeros[i] > max)
                {
                    max = numeros[i];
                    
                }
               
                    if (numeros[i] < min)
                    {
                        min = numeros[i];
                        
                    }
                
            }
            Console.WriteLine("] ");
            Console.WriteLine();
            Console.WriteLine($" El maximo valor = {max}");
            Console.WriteLine($" El minimo valor = {min}");
            Console.WriteLine();
            Console.WriteLine("****************");
            Console.WriteLine(" Fin del Proceso");
            Console.WriteLine("****************");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
