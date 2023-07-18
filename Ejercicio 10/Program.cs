using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" ++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Busqueda de un nombre dentro de un vector de nombres");
            Console.WriteLine(" ++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            string[] nombres = {"Carlos","Micaela","Ricardo","Rocio","Nicolas"};
            string nombre = " ";
            bool bandera = false;
            Console.Write(" Ingresar el nombre que busca = ");
            nombre = Console.ReadLine();
            Console.WriteLine();
            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombre == nombres[i])
                {
                    bandera = true;
                    
                }
                
            }
            if (bandera)
            {
               Console.WriteLine(" El nombre ingresado esta dentro de Array");
            }
            else
            {
             Console.WriteLine(" Nuestro nombre  NO esta en el Array");
            }
            Console.WriteLine();
            Console.Write(" Nombres = [");
            //muestra un vector sin necesidad de usar un for
            Console.Write(String.Join(", ",nombres));
            Console.WriteLine("] ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("****************");
            Console.WriteLine(" Fin del Proceso");
            Console.WriteLine("****************");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
