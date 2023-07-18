using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" ++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Ordenar un Array por metodo Burbuja de menor a mayor");
            Console.WriteLine(" ++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int num = 0;
            int aux = 0;
            Console.Write(" Ingresar la longitud del vector = ");
            num = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] vector = new int[num];
            Console.WriteLine();
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($" Ingresar {i + 1}° elemnto del vector = ");
                vector[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine(" Vector Sin Ordenar ");
            Console.WriteLine();
            Console.Write(" Vector = [");
            Console.Write(string.Join(", ", vector));
            Console.WriteLine("] ");
            Console.WriteLine();
            //utilizo un for dentro de otro el primero con la longitud real y el segundo que esta dentro con longitud -1
            for (int i = 0; i < vector.Length; i++)
            {

                for (int j = 0; j < (vector.Length - 1); j++)
                {
                    if (vector[j] > vector[j + 1])
                    {
                        aux = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = aux;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(" Vector Ordenado por metodo Burbuja ");
            Console.WriteLine();
           Console.Write(" Vector = [");
            //Array.Sort(vector);
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
