using System;

namespace Ejercicio_3.__Histograma
{
    class Program
    {
        static void Main(string[] args)
        {
            int vecindad = 0;
            int cantidad = 0;
            double mayor = -999999;
            double menor = 999999;
            double dato;
            Console.WriteLine("Hola, ingrese la cantidad de datos que desea ingresar: ");
                cantidad = Convert.ToInt32(Console.ReadLine());
            double[] datos = new double[cantidad];
            

            for (int i=0; i<cantidad; i++)
            {
                int num = i + 1;
                Console.WriteLine("Ingrese el número "+ num +": ");
                dato = Convert.ToDouble(Console.ReadLine());
                datos[i] = dato;
                 

                if (dato > mayor)
                { 
                    mayor = dato;
                }

                if (dato < menor)
                {
                    menor = dato;
                }
            }


            double número_intervalos = 1 + (3.3 * Math.Log10(mayor - menor));
            int número_intervalos_entero= Convert.ToInt32 (Math.Floor(número_intervalos));
            double delta_intervalo = (mayor - menor) / número_intervalos;

            double cantidad_en_double = Convert.ToDouble(cantidad);

            double promedio=0;
            double suma = 0;

            for (int i=0; i<cantidad; i++)
            {

                suma = suma + datos[i];
                promedio=suma/ cantidad_en_double;
            }
              


            int[] cantidades = new int[número_intervalos_entero+2];
            int k = 0;

            for (double i=menor; i<=mayor; i=i+delta_intervalo)
            { 
                int contador = 0;

                for (int j = 0; j < cantidad; j++)
                {
                    
                    if (datos[j]>=i && datos[j]<i+delta_intervalo )
                    {
                        contador = contador + 1;
                    }
                    
                }
                cantidades[k] = contador;
                double delta= delta_intervalo+i;

                int intervalo_medio = Convert.ToInt32( Math.Floor(número_intervalos/2));
                
                if (promedio>=i && promedio <= delta)
                {
                    int intervalo_actual = k + 1;
                    if (intervalo_actual>=intervalo_medio-2 || intervalo_actual <=intervalo_medio+2)
                    {
                        vecindad = 1;
                    }

                    else { 
                        vecindad = 3; 
                    }
                }
                

                if (cantidades[k]>0 && delta<=mayor)
                {
                    Console.WriteLine("Entre " + i +  " y  "+delta+" hay " + cantidades[k] + " datos.");
                    for (int m=0; m<cantidades[k]; m++)
                    {
                        Console.Write(" | ");
                    }
                    Console.WriteLine("");

                }

                else if (cantidades[k] > 0)
                {
                    Console.WriteLine("Entre " + i + " y  " + mayor + " hay " + cantidades[k] + " datos.");
                    for (int m = 0; m < cantidades[k]; m++)
                    {
                        Console.Write(" | ");
                    }
                    Console.WriteLine("");

                }

                k = k + 1;

            }

            if (vecindad < 2)
            {
                Console.WriteLine("El promedio es " + promedio + " y se encuentra al menos en la segunda vecindad.");
            }

            else
            {
                Console.WriteLine("El promedio es " + promedio + " y se no encuentra al menos en la segunda vecindad.");
            }

            

            Console.ReadKey();

            










        }
    }
}
