using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumeroMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un primer numero ");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa un seugundo numero ");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa un tercer numero ");
            int c = Int32.Parse(Console.ReadLine());

            if (a>b && a>c)
            {
                Console.WriteLine("El numero mayor es: "+ a);
            }
            else
            {
                if (b>a && b>c)
                {
                    Console.WriteLine("El numero mayor es: " + b);
                }
                else
                {
                    Console.WriteLine("El numero mayor es: " + c);
                }
            }

            

            Console.ReadKey();
        }
    }
}
