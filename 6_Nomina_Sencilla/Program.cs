using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_Nomina_Sencilla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingresa numero de horas trabajadas: ");
            int horas = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa valor hora: ");
            int valor = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa valor salario minimo");
            int minimo = Int32.Parse(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
