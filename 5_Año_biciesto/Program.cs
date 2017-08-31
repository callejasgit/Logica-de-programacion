using System;




namespace _5_Año_biciesto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un año");
            int ano = Int32.Parse(Console.ReadLine());

            if (esBiciesto(ano))
            {
                Console.WriteLine("el año " + ano + " si es biciesto");
            }
            else
            {
                Console.WriteLine("el año " + ano + " no es biciesto");
            }
            Console.ReadKey();
        }




        /// <summary>
        /// metodo año biciesto
        /// </summary>
        /// <param name="ano"></param>
        /// <returns></returns>
        public static bool esBiciesto( int ano)
        {
            if (ano % 4 == 0)
            {
                if (ano % 100 == 0)
                {
                    if (ano % 400 == 0)
                    {
                        return true; // Console.WriteLine("el año " + ano + " si es biciesto");
                    }
                    else
                    {
                        return false; //Console.WriteLine("el año " + ano + " no es biciesto");
                    }
                }
                else
                {
                    return true; //Console.WriteLine("el año " + ano + " si es biciesto");
                }
            }
            else
            {
                return false; //Console.WriteLine("el año "+ano+ " no es biciesto");
            }
        }
    }
}
