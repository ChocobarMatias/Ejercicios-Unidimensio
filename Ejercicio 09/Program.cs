using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Vector de 10 notas (del 1 al 10) - Promedio - Promocion - Regular - Irregular");
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int[] nota = new int[10];
            int suma = 0;
            int promedio = 0;
            Console.WriteLine();
            for (int i = 0; i < nota.Length; i++)
            {
                Console.Write($" Ingresar la {i+1}° nota del alumno = ");
                nota[i]= Int32.Parse(Console.ReadLine());
                suma += nota[i];
            }
            Console.WriteLine();
            Console.Write(" Notas = [");
            Console.Write(string.Join(", ", nota));
            Console.WriteLine("] ");
            Console.WriteLine();
            promedio = suma / (nota.Length);
            Console.WriteLine($" Promedio de Notas = {promedio}");
            Console.WriteLine();
            if (promedio >= 8)
            {
                Console.WriteLine(" Promocionado");
            }
            else
            {
                if (promedio < 8 && promedio >= 6)
                {
                    Console.WriteLine(" Regular");
                }
                else
                {
                    Console.WriteLine(" Irregular");
                }
            }

            Console.WriteLine();
            Console.WriteLine("****************");
            Console.WriteLine(" Fin del Proceso");
            Console.WriteLine("****************");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
