using System;

namespace Ejericicio_4._Rufini
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el grado del polinomio a dividir.");
            int grado_plinomio = Convert.ToInt32(Console.ReadLine());
            double[] Coeficientes = new double [grado_plinomio+2];

            for (int i=0; i<=grado_plinomio; i++)
            {
                Console.WriteLine("Introduzca  el coeficiente que acompaña a x^" + i + ": ");
                Coeficientes[i] = Convert.ToDouble(Console.ReadLine());
            }


            Console.WriteLine("Por cuál número quiere comprobar si es raíz: ");
            double número_raiz = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i <= grado_plinomio; i++)
            {
                int grado_a_mostrar = grado_plinomio - i;
                Console.Write(" " + Coeficientes[grado_a_mostrar] + "x^"+ grado_a_mostrar+" ");
                
            }

            Console.Write("|___");
            Console.Write("" + número_raiz + "");
            Console.WriteLine("______");


            Console.Write(" " + Coeficientes[grado_plinomio] + " ");
            double número_multiplicado = Coeficientes[grado_plinomio]*número_raiz;
            double número_sumado = 0;
            

            for (int i = 0; i < grado_plinomio; i++)
            {
                int grado_a_mostrar = (grado_plinomio) - i;

                número_sumado = número_multiplicado + Coeficientes[grado_a_mostrar-1];
                número_multiplicado= número_sumado * número_raiz;
                Console.Write("   " + número_sumado + "   ");
            }

            Console.WriteLine("");
            if(número_sumado == 0)
            {
                Console.WriteLine("" + número_raiz + " es raíz del polinomio propuesto. ");
            }

            else
            {
                Console.WriteLine("" + número_raiz + " no es raíz del polinomio propuesto. ");
            }

            Console.WriteLine("Adiós. Muak");
            Console.ReadKey();

        }    
    }
}
