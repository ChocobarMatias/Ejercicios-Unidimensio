using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Vector Nombre, apellido, edad, sexo de 5 clientes");
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            string[] Nombre = new string[5];
            string[] Apellido = new string[5];
            string[] sexo = new string[5];
            int[] edad = new int[5];
            Console.WriteLine();
            for (int i = 0; i < Nombre.Length; i++)
            {
                Console.Write($" Ingresar {i + 1}° Nombre = ");
                Nombre[i] = Console.ReadLine();

            }
            Console.WriteLine();
            for (int i = 0; i < Apellido.Length; i++)
            {
                Console.Write($" Ingresar {i + 1}° Apellido = ");
                Apellido[i] = Console.ReadLine();
            }
            Console.WriteLine();
            for (int i = 0; i < sexo.Length; i++)
            {
                Console.Write($" Ingresar Sexo de la {i + 1}° persona = ");
                sexo[i] = Console.ReadLine();

            }
            Console.WriteLine();
            for (int i = 0; i < edad.Length; i++)
            {
                Console.Write($" Ingresar edad de la {i + 1}° persona = ");
                edad[i] = Int32.Parse(Console.ReadLine());

            }
            Console.Clear();
            Console.WriteLine();
            Console.Write(" . Nombre = [ ");
            for (int i = 0; i < Nombre.Length; i++)
            {
                
                if (i < Nombre.Length - 1)
                {

                    Console.Write($" {Nombre[i]}, ");
                }
                else { Console.Write($" {Nombre[i]}"); }
            }
            Console.WriteLine(" ] ");
            Console.WriteLine();
            Console.Write(" . Apellido = [ ");
            for (int i = 0; i < Apellido.Length; i++)
            {
               
                if (i < Apellido.Length - 1)
                {
                    Console.Write($" {Apellido[i]}, ");
                }
                else { Console.Write($" {Apellido[i]}"); }
            }
            Console.WriteLine(" ] ");
            Console.WriteLine();
            Console.Write(" . Sexo = [ ");
            for (int i = 0; i < sexo.Length; i++)
            {
               
                if (i < sexo.Length - 1)
                {
                    Console.Write($" {sexo[i]}, ");
                }
                else { Console.Write($" {sexo[i]}"); }
            }
            Console.WriteLine(" ] ");
            Console.WriteLine();
            Console.Write(" . Edad = [ ");
            for (int i = 0; i < edad.Length; i++)
            {
               
                if (i < edad.Length - 1)
                {
                    Console.Write($" {edad[i]}, ");
                }
                else { Console.Write($" {edad[i]}"); }
            }
            Console.WriteLine(" ] ");

            Console.WriteLine();
            Console.WriteLine(" ***************");
            Console.WriteLine(" Fin del Proceso");
            Console.WriteLine(" ***************");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
