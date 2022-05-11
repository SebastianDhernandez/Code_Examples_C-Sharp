using System; 

namespace Ejercicio_1._Promedio_de_números_ingresados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola. \n Ingrese la cantidad de números que desea promediar: ");
            int n= Convert.ToInt32(Console.ReadLine());
            int sumador = 0;
            int número = 0;
            double promedio = 0;
            for (int i = 1; i <= n; i ++)
            {
                Console.WriteLine("Ingrése el número de la posición " + i.ToString() + " :");
                número = Convert.ToInt32(Console.ReadLine());
                sumador = sumador + número;
            }
            promedio = sumador / n;
            Console.WriteLine("El proimedio de los números ingresados es: " + promedio.ToString());
        }
    }
}
