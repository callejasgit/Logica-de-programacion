using System;




namespace _4_Numero_multiplo_de_otro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa primer Numero ");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa segundo Numero ");
            int b = Int32.Parse(Console.ReadLine());

            if (a % b == 0)
            {
                Console.WriteLine("El numero: " + b + " es multiplo de " +a);
            }
            else
            {
                Console.WriteLine("El numero: " + b + " no es multiplo de "+a);
            }

            Console.ReadKey();
        }
    }
}
