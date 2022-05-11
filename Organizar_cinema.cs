using System;

namespace Ejercicio_2._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola usuario, tenemos dos salas de cine. Define la capacidad de estas en número de asientos: ");
            int asientos = Convert.ToInt32(Console.ReadLine());
            int m=0, n=9999;
            int valor_general = 5000;
            int valor_vip = valor_general + 4000;
            int columna = 0;
            int fila = 0;
            int p, q;

            for (int i=1; i<(asientos); i++)
            {
                if (asientos % i == 0)
                {
                    int m_new = i;
                    int n_new = asientos / i;

                    if (n_new-m_new < n - m  &&  n_new-m_new>=0)
                    {
                        m = m_new;
                        n = n_new;
                    }
                }
            }

            p = m;
            q = n;


            int[,] Sala_1 = new int[m, n];

            for (int i=0; i<m; i++)
            {
                for (int j = 0; j < n;  j++)
                {
                    Sala_1[i, j] = 0;
                }
            }



            int[,] Sala_2 = new int[p, q];
            for (int i = 0; i < p;  i++)
            {
                for (int j = 0; j < q; j++)
                {
                    Sala_1[i, j] = 0;
                }
            }

            int opción=0;

            Console.WriteLine("1. Entrar a la información de la sala 1.");
            Console.WriteLine("2. Entrar a la información de la sala 2.");
            Console.WriteLine("3. Salir.");
            opción = Convert.ToInt32(Console.ReadLine());

            while (opción != 3)
            {
                switch (opción)
                {
                    case 1:


                        Console.WriteLine("Bienvenido a la primera sala. Los asientos con ceros están vacíos, los " +
                            "asientos con unos son generales ocupados y los asientos con doces son VIP ocupados. El costo" +
                            "básico por defecto es de 5000.");


                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                Console.Write(" "+Sala_1[i,j] +" ");
                            }

                            Console.Write("\n");
                            Console.Write("\n");
                        }


                        Console.WriteLine("1. Asignar asientos.");
                        Console.WriteLine("2. Desocupar asientos.");
                        Console.WriteLine("3. Ver recaudo.");
                        Console.WriteLine("4. Definir el costo básico del asiento.");
                        int opción_2 = Convert.ToInt32(Console.ReadLine());
                        int caja = 0;
                        

                        switch (opción_2)
                        {
                            case 1:

                                Console.Clear();

                                if (n < 8)
                                {
                                    Console.WriteLine("Designe la columna donde está el asiento a asignar. Si el asiento " +
                                    "es preferencial, ubíquelo en las columnas de la 1 a la "+n+". ");
                                    columna = Convert.ToInt32(Console.ReadLine());
                                }
                                else
                                {
                                    Console.WriteLine("Designe la columna donde está el asiento a asignar. Si el asiento " +
                                    "es preferencial, ubíquelo en las columnas de la 1 a la 8. ");
                                    columna = Convert.ToInt32(Console.ReadLine());
                                }
                                

                                Console.WriteLine("Designe la fila donde está el asiento a asignar. Si el asiento es " +
                                    "preferencial, ubíquelo en la fila número "+ m + ". ");
                                     fila= Convert.ToInt32(Console.ReadLine());

                                if(columna<=0 || columna>n || fila<=0 || fila > m)
                                {
                                    Console.WriteLine("Los valores de fila o de columna no son válidos.");
                                }

                                if (fila==m && columna<= 8)
                                {
                                    Sala_1[fila-1, columna-1] = 2;
                                }
                                else
                                {
                                    Sala_1[fila-1, columna-1] = 1;
                                }
                                Console.Clear();

                                break;



                            case 2:

                                Console.Clear();
                                Console.WriteLine("Designe la columna donde está el asiento a desocupar. Si el asiento " +
                                   "es preferencial, ubíquelo en las columnas de la 1 a la 8. ");
                                columna = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Designe la fila donde está el asiento a desocupar. Si el asiento es " +
                                    "preferencial, ubíquelo en la fila número " + m + ". ");
                                fila = Convert.ToInt32(Console.ReadLine());

                                if (columna <= 0 || columna > n || fila <= 0 || fila > m)
                                {
                                    Console.WriteLine("Los valores de fila o de columna no son válidos.");
                                }

                                Sala_1[fila-1, columna-1] = 0;
                                Console.Clear();

                                break;



                            case 3:
                                Console.Clear();
                                int contador_general=0;
                                int contador_vip=0;

                                for (int i = 0; i < m; i++)
                                {
                                    for (int j = 0; j < n; j++)
                                    {
                                        if (Sala_1[i,j]==1)
                                        {
                                            contador_general = contador_general + 1;
                                        }

                                        if(Sala_1[i, j] == 2)
                                        {
                                            contador_vip = contador_vip + 1;
                                        }
                                    }

                                }
                                caja = (contador_general * valor_general) + (contador_vip * valor_vip);
                                Console.WriteLine("El valor recaudado al momento es de " + caja + " pesos. " +
                                    "Oprima cualquier botón para volver.");
                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 4:
                                Console.WriteLine("Defina el valor del costo del asiento general: ");
                                valor_general = Convert.ToInt32(Console.ReadLine());
                                valor_vip = valor_general + 4000;
                                break;
                                

                        }















                        break;
                    case 2:


                        Console.WriteLine("Bienvenido a la segunda sala. Los asientos con ceros están vacíos, los " +
                            "asientos con unos son generales ocupados y los asientos con doces son VIP ocupados. El costo" +
                            "básico por defecto es de 5000.");


                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                Console.Write(" " + Sala_2[i, j] + " ");
                            }

                            Console.Write("\n");
                            Console.Write("\n");
                        }


                        Console.WriteLine("1. Asignar asientos.");
                        Console.WriteLine("2. Desocupar asientos.");
                        Console.WriteLine("3. Ver recaudo.");
                        Console.WriteLine("4. Definir el costo básico del asiento.");
                        opción_2 = Convert.ToInt32(Console.ReadLine());
                        caja = 0;

                        switch (opción_2)
                        {
                            case 1:

                                Console.Clear();
                                if (n < 8)
                                {
                                    Console.WriteLine("Designe la columna donde está el asiento a asignar. Si el asiento " +
                                    "es preferencial, ubíquelo en las columnas de la 1 a la " + n + ". ");
                                    columna = Convert.ToInt32(Console.ReadLine());
                                }
                                else
                                {
                                    Console.WriteLine("Designe la columna donde está el asiento a asignar. Si el asiento " +
                                    "es preferencial, ubíquelo en las columnas de la 1 a la 8. ");
                                    columna = Convert.ToInt32(Console.ReadLine());
                                }

                                Console.WriteLine("Designe la fila donde está el asiento a asignar. Si el asiento es " +
                                    "preferencial, ubíquelo en la fila número " + m + ". ");
                                    fila = Convert.ToInt32(Console.ReadLine());

                                if (columna <= 0 || columna > n || fila <= 0 || fila > m)
                                {
                                    Console.WriteLine("Los valores de fila o de columna no son válidos.");
                                }

                                if (fila == m && columna <= 8)
                                {
                                    Sala_2[fila-1, columna-1] = 2;
                                }
                                else
                                {
                                    Sala_2[fila-1, columna-1] = 1;
                                }
                                Console.Clear();

                                break;



                            case 2:

                                Console.Clear();
                                Console.WriteLine("Designe la columna donde está el asiento a desocupar. Si el asiento " +
                                   "es preferencial, ubíquelo en las columnas de la 1 a la 8. ");
                                columna = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Designe la fila donde está el asiento a desocupar. Si el asiento es " +
                                    "preferencial, ubíquelo en la fila número " + n + ". ");
                                fila = Convert.ToInt32(Console.ReadLine());

                                if (columna <= 0 || columna > n || fila <= 0 || fila > m)
                                {
                                    Console.WriteLine("Los valores de fila o de columna no son válidos.");
                                }

                                Sala_2[fila-1, columna-1] = 0;
                                Console.Clear();

                                break;



                            case 3:
                                Console.Clear();
                                int contador_general = 0;
                                int contador_vip = 0;

                                for (int i = 0; i < m; i++)
                                {
                                    for (int j = 0; j < n; j++)
                                    {
                                        if (Sala_2[i, j] == 1)
                                        {
                                            contador_general = contador_general + 1;
                                        }

                                        if (Sala_2[i, j] == 2)
                                        {
                                            contador_vip = contador_vip + 1;
                                        }
                                    }

                                }
                                caja = (contador_general * valor_general) + (contador_vip * valor_vip);
                                Console.WriteLine("El valor recaudado al momento es de " + caja + " pesos.");

                                break;

                            case 4:
                                Console.Clear();
                                Console.WriteLine("Defina el valor del costo del asiento general: ");
                                valor_general = Convert.ToInt32(Console.ReadLine());
                                valor_vip = valor_general + 4000;
                                break;
                        }

                        break;


                    case 3:
                        Console.Clear();
                        Console.WriteLine("Adiós.");

                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opción inválida, oprima cualquier tecla para volver al menú.");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                }
            }



        }
    }
}
