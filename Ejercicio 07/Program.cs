using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" ++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Ordenar un Array por metodo de Sort de menor a mayor");
            Console.WriteLine(" ++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int num = 0;
            Console.Write(" Ingresar la longitud del vector = ");
            num = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] vector = new int[num];
            Console.WriteLine();
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($" Ingresar {i+1}° elemnto del vector = ");
                vector[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine(" Vector Sin Ordenar ");
            Console.WriteLine();
            Console.Write(" Vector = [");
            Console.Write(string.Join(", ", vector));
            Console.WriteLine("] ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Vector Ordenado por metodo de Sort ");
            Console.WriteLine();
            Console.Write(" Vector = [");
            Array.Sort(vector);
            Console.Write(string.Join(", ", vector));//metodo para agregar comas u otra cosa entre cada elemento
            Console.WriteLine("] ");
            Console.WriteLine();
            Console.WriteLine("****************");
            Console.WriteLine(" Fin del Proceso");
            Console.WriteLine("****************");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
