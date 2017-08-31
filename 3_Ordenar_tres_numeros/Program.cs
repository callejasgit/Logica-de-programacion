using System;





namespace _3_Ordenar_tres_numeros
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

            

            if (a > b && a > c)
            {
                Console.WriteLine("El numero mayor es: " + a);
                if (b>c)
                {
                    Console.WriteLine("El numero del medio es: " + b);
                    Console.WriteLine("El numero menor es: " + c);
                }
                else
                {
                    Console.WriteLine("El numero del medio es: " + c);
                    Console.WriteLine("El numero menor es: " + b);
                }
            }
            else
            {
                if (b > a && b > c)
                {
                    Console.WriteLine("El numero mayor es: " + b);
                    if (a > c)
                    {
                        Console.WriteLine("El numero del medio es: " + c);
                        Console.WriteLine("El numero menor es: " + a);
                    }
                    else
                    {
                        Console.WriteLine("El numero del medio es: " + a);
                        Console.WriteLine("El numero menor es: " + c);
                    }
                }
                else
                {
                    Console.WriteLine("El numero mayor es: " + c);
                    if (a > b)
                    {
                        Console.WriteLine("El numero del medio es: " + a);
                        Console.WriteLine("El numero menor es: " + b);
                    }
                    else
                    {
                        Console.WriteLine("El numero del medio es: " + b);
                        Console.WriteLine("El numero menor es: " + a);
                    }

                }
            }
            Console.ReadKey();
        }
    }
}
