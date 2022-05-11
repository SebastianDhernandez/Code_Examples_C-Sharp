using System;

namespace Ejercicio_5._Combinaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int número_1=0;
            int número_2=0;
            int número_3=0;

            Console.WriteLine("Hola. Elige 3 números enteros y te diremos cuántas combinaciones.");
            Console.WriteLine("Elige el primer número: ");
            número_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Elige el segundo número: ");
            número_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Elige el tercer número: ");
            número_3 = Convert.ToInt32(Console.ReadLine());






            if (número_1 != número_2 && número_1 != número_3 && número_2!=número_3)
            {

                if (número_1 == 0 || número_2 == 0 || número_3 == 0)
                {
                    Console.WriteLine("El número de combinaciones posibles es de 24. ");
                }

                else
                {
                    Console.WriteLine("El número de combinaciones posibles es de 48. ");
                }
            }



            else if (número_1 == número_2 && número_1 == número_3)
            {
                if (número_1 == 0)
                {
                    Console.WriteLine("El número de combinaciones posibles es de 1. ");
                }

                else
                {
                    Console.WriteLine("El número de combinaciones posibles es de 8. ");
                }
            }





            else if (número_1 == número_2 || número_1 == número_3 || número_2==número_3)
            {



                if (número_1 == 0 || número_2 == 0 || número_3 == 0)
                {
                    if (número_1 == 0 && número_2 == 0)
                    {
                        Console.WriteLine("El número de combinaciones posibles es de 6. ");
                    }

                    else if (número_2 == 0 && número_3 == 0)
                    {
                        Console.WriteLine("El número de combinaciones posibles es de 6. ");
                    }

                    else if (número_1 == 0 && número_3 == 0)
                    {
                        Console.WriteLine("El número de combinaciones posibles es de 6. ");
                    }

                    else
                    {
                        Console.WriteLine("El número de combinaciones posibles es de 12. ");
                    }
                }

                else
                        {
                    Console.WriteLine("El número de combinaciones posibles es de 24. ");
                        }

            }

            else if(número_1 == número_2 && número_1 == número_3)
            {
                if (número_1 == 0)
                {
                    Console.WriteLine("El número de combinaciones posibles es de 1. ");
                }

                else
                {
                    Console.WriteLine("El número de combinaciones posibles es de 8. ");
                }
            }
           

        }
    }
}
