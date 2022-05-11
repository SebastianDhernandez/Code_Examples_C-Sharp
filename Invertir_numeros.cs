using System;

namespace Invertir_número
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola. Ingrese un número natural de dos cifras: ");
            int número = Convert.ToInt32( Console.ReadLine());

            if (número > 99)
            {
                while (número > 99)
                {
                    Console.WriteLine("El número debe ser de dos cifras, intente de nuevo: ");
                    número = Convert.ToInt32(Console.ReadLine());
                }
            }

            if (número < 0)
            {
                while (número < 0)
                {
                    Console.WriteLine("El número debe ser natural, intente de nuevo: ");
                    número = Convert.ToInt32(Console.ReadLine());
                }
            }

            
            int división = número / 10;
            int módulo = número % 10;
            Console.WriteLine("El número invertido es " + módulo.ToString() + división.ToString());



        }
    }
}
