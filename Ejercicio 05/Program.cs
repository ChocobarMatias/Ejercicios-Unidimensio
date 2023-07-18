using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Verificador de tipo de triangulo, Equilatero, Isoceles, Escaleno");
            Console.WriteLine(" ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int lado1 = 0;
            int lado2 = 0;
            int lado3 = 0;
            int[] triangulo = new int[3];
            Console.WriteLine();
            for (int i = 0; i < triangulo.Length; i++)
            {
                Console.Write($" Ingresar Lado {i+1} del triangulo = ");
                triangulo[i]= Int32.Parse(Console.ReadLine());
                lado1 = triangulo[i];
            }
            Console.WriteLine();
            Console.Write(" Triangulo = [");
            for (int i = 0; i < triangulo.Length; i++)
            {
                
                if (i < triangulo.Length - 1)
                {
                    Console.Write($" {triangulo[i]}, ");
                }
                else
                {
                    Console.Write($" {triangulo[i]}");
                }
                
            }
            Console.WriteLine("] ");
            Console.WriteLine();
            if (triangulo[0] == triangulo[1] && triangulo[1] == triangulo[2])
            {
                Console.WriteLine(" El Triangulo es Equilatero");
            }
            else
            {
                if (triangulo[0] == triangulo[1] || triangulo[0] == triangulo[2] || triangulo[2] == triangulo[1])
                {
                    Console.WriteLine(" El Triangulo es Isosceles");
                }
                else
                {
                    if (triangulo[0] != triangulo[1] || triangulo[1] != triangulo[2] || triangulo[2] != triangulo[0])
                    { Console.WriteLine(" El Triangulo es Escaleno"); }
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
