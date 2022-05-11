using System;

namespace Menú
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Bienvenido. Nuestro menú");

            Boolean entrada_al_menú = true;
            Boolean confirmador_inferior = false;
            Boolean confirmador_superior = false;
            int límite_inferior=0;
            int límite_superior=0;


            while (entrada_al_menú == true)
            {


                Console.WriteLine("Elija una de las siguientes opciones: ");

                Console.WriteLine("1. Elegir el límite inferior. \n 2. Elegir el límite superior. \n " +
                    "3. Determinar la suma y promedio de los parees e impares entre los límites asignados. \n 4. Salir.");

                int opción = Convert.ToInt32(Console.ReadLine());
                



                switch (opción)
                {

                    case 1:
                        Console.WriteLine("Establezca el límite inferior, debe ser un número entero: ");
                        límite_inferior = Convert.ToInt32(Console.ReadLine());
                        confirmador_inferior = true;


                        break;




                    case 2:

                        Console.WriteLine("Establezca el límite superior, debe ser un número entero: ");
                        límite_superior = Convert.ToInt32(Console.ReadLine());
                        confirmador_superior = true;


                        break;




                    case 3:

                        if (confirmador_inferior == false || confirmador_superior == false)
                        {
                            Console.WriteLine("Usted no ha establecido alguno de los límites, reingrese al menú e ingréselos seleccionando" +
                                "la opción correspondiente.");
                            break;
                        }


                        if (límite_inferior >= límite_superior)
                        {
                            Console.WriteLine("El límite inferior seleccionado es mayor o igual al límite superior seleccionado. " +
                                "Debe reescribir alguno de los límites de tal forma que el inferior sea menor que el superior.");
                            break;
                        }

                        int sumador_par = 0;
                        int contador_par = 0;
                        int sumador_impar = 0;
                        int contador_impar = 0;


                        for (int i = límite_inferior; i <= límite_superior; i++)
                        {

                            if (i%2 == 0)
                            {
                                sumador_par = sumador_par + i;
                                contador_par = contador_par + 1;
                            }

                            if (i % 2 != 0)
                            {
                                sumador_impar = sumador_impar + i;
                                contador_impar = contador_impar + 1;
                            }

                        }

                        int promedio_par = sumador_par / contador_par;
                        int promedio_impar = sumador_impar / contador_impar;

                        Console.WriteLine("La suma de los números pares es " + sumador_par.ToString() +
                            " y su promedio es " + promedio_par.ToString());
                        Console.WriteLine("La suma de los números impares es " + sumador_impar.ToString() +
                            " y su promedio es " + promedio_impar.ToString());

                        break;



                    case 4:

                        entrada_al_menú = false;

                        break;

                    default:

                        Console.WriteLine("Opción no válida. Vuelva a ingresar una opción. ");

                        break;
                }

            }



        }
    }
}
