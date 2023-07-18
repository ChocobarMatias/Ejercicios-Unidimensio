using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Unidimensio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" ++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Vector Nombre de 4 alumnos y sus Notas");
            Console.WriteLine(" ++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int[] Notas = new int[4];
            string[] Nombre = new string[4];
            Console.WriteLine();
            for (int i = 0; i < Nombre.Length; i++)
            {
                Console.Write($" Ingresar el nombre del alumno {i+1} = ");
                Nombre[i] = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine();
            for (int i = 0; i < Notas.Length; i++)
            {
                Console.Write($" Ingresar la Nota del alumno {Nombre[i]} = ");
                Notas[i] = Int32.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine();
            Console.Write(" [");
            for (int i = 0; i < Notas.Length; i++)
            {
                if (i < Notas.Length - 1)
                {
                Console.Write($" {Nombre[i]} = {Notas[i]} ,");
             
                }
                else
                {
                    Console.Write($" {Nombre[i]} = {Notas[i]}");
                }
            }
            Console.Write(" ] ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
