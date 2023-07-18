using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Suma de n cantidades de precios de los productos ");
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int n = 0;
            int suma = 0;
            Console.Write(" Ingresar un valor N = ");
            n = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
           
             int[] precios = new int[n];
           string[] producto = new string[n];

            Console.WriteLine();
            for (int i = 0; i < producto.Length; i++)
            {
                Console.Write($" Ingresar {i+1}° producto = ");
                producto[i] = Console.ReadLine(); 
            }
            Console.WriteLine();
            for (int i = 0; i <precios.Length; i++)
            {
                Console.Write($" Ingresar precio del {i + 1}° producto = $");
                precios[i] = Int32.Parse(Console.ReadLine());
                suma += precios[i];
            }
            Console.Clear();
            Console.WriteLine();
            Console.Write(". producto = [");
            for (int i = 0; i < producto.Length; i++)
            {
                
                if (i < producto.Length - 1)
                {
                 Console.Write($" {producto [i]}, ");
                }
                else
                {
                    Console.Write($" {producto[i]} ");
                }
            }
            Console.Write("] ");
            Console.WriteLine();
            Console.Write(". Precios = [");
            for (int i = 0; i < precios.Length; i++)
            {
               
                if (i < precios.Length - 1)
                {
                    Console.Write($" $ {precios[i]}, ");
                }
                else
                {
                    Console.Write($" $ {precios[i]} ");
                }
            }
            Console.Write("] ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($" Suma de Precios = $ {suma}");

            Console.WriteLine();
            Console.WriteLine("****************");
            Console.WriteLine(" Fin del Proceso");
            Console.WriteLine("****************");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
