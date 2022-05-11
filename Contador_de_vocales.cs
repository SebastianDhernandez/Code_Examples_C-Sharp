using System;

namespace Ejercicio_6._Contar_vocales
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            string letra;
            int contador_a=0;
            int contador_e=0;
            int contador_i=0;
            int contador_o=0;
            int contador_u=0;


            Console.WriteLine("Hola. Introduzca su frase: ");
            frase = Console.ReadLine().ToLower();


            for (int i=0;i<(frase.Length); i++)
            {
                letra=frase.Substring(i, 1);

                if (letra == "a" || letra== "á")
                {
                    contador_a = contador_a + 1;

                }

                if (letra == "e" || letra == "é")
                {
                    contador_e = contador_e + 1;

                }

                if (letra == "i" || letra == "í")
                {
                    contador_i = contador_i + 1;

                }

                if (letra == "o" || letra == "ó")
                    {
                    contador_o = contador_o + 1;

                }

            if (letra == "u" || letra == "ú")
                {
                contador_u = contador_u + 1;

            }



            }

            Console.WriteLine("La vocales son: a="+ contador_a + " e="+ contador_e + " i=" + contador_i + " o=" + contador_o + " u=" + contador_u);

            System.Threading.Thread.Sleep(3000);


        }
    }
}
