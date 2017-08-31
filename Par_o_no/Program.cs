using System;




namespace Par_o_no
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un Numero ");
            int num = Int32.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("El numero: " + num + " es par");
            }
            else
            {
                Console.WriteLine("El numero: " + num + " es impar");
            }
                
            Console.ReadKey();

        }
    }
}
