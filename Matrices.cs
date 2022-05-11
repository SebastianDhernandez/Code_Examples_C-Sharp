using System;

namespace Ejercicio_1.__Operaciones_con_matrices
{
    class Program
    {
        static void Main(string[] args)
        {
			int m = 0;
			int n = 0;
			int p = 0;
			int q = 0;
			int opción = 0;
			

			Console.Write("Defina el número de filas de la primera matriz: ");
			m = Convert.ToInt32(Console.ReadLine());
			Console.Write("\n");
			Console.Write("Defina el número de columnas de la primera matriz: ");
			n = Convert.ToInt32(Console.ReadLine());
			Console.Write("\n");

			int[,] Matriz_1=new int[m,n];

			Console.WriteLine("Ingrese las componentes de la primera matriz: ");

			for (int i = 0; i < m; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.WriteLine("Ingrese valor: ");
					Matriz_1[i,j] = Convert.ToInt32(Console.ReadLine());
				}
				Console.Write("\n");
				Console.Write("\n");
			}


			Console.Write("Defina el número de filas de la segunda matriz: ");
			p = Convert.ToInt32(Console.ReadLine());
			Console.Write("\n");
			Console.Write("Defina el número de columnas de la segunda matriz: ");
			q = Convert.ToInt32(Console.ReadLine());
			Console.Write("\n");

			int[,] Matriz_2 = new int [p,q] ; 

			Console.WriteLine("Ingrese las componentes de la segunda matriz: ");

			for (int i = 0; i < p; i++)
			{
				for (int j = 0; j < q; j++)
				{
					Console.WriteLine("Ingrese valor: ");
					Matriz_2[i,j] = Convert.ToInt32(Console.ReadLine());
				}
				Console.Write("\n");
				Console.Write("\n");
			}

			Console.Clear();

			Console.WriteLine("MENÚ: ");



			while(opción != 5)
            {
				Console.WriteLine("1. Sumar matrices.");
				Console.WriteLine("2. Restar matrices.");
				Console.WriteLine("3. Multiplicar matrices, si es posible.");
				Console.WriteLine("4. Multiplicar matrices por un escalar.");
				Console.WriteLine("5. Salir.");
				opción = Convert.ToInt32(Console.ReadLine());
				switch (opción)
                {
					case 1:

						if (m!=p || n != q)
                        {
							Console.WriteLine("No se pueden sumar las matrices porque sus dimensiones son diferentes");
                        }

                        else
                        {
							Console.WriteLine("");

							int[,] Matriz_resultado = new int[m, n];

							for (int i = 0; i < m; i++)
							{
								for (int j = 0; j < n; j++)
								{
									Matriz_resultado[i, j] = Matriz_1[i, j] + Matriz_2[i, j];
								}
							}


							Console.WriteLine("La matriz resultante es : ");

							for (int i = 0; i < m; i++)
							{
								for (int j = 0; j < n; j++)
								{
									Console.Write(" " + Matriz_resultado[i,j] + " ");
								}
								Console.Write("\n");
							}
							Console.WriteLine("Presione cualquier tecla para volver al menú");
							Console.ReadKey();
							Console.Clear();
						}


						break;



					case 2:

						if (m != p || n != q)
						{
							Console.WriteLine("No se pueden restar las matrices porque sus dimensiones son diferentes");
						}

						else
						{
							Console.WriteLine("");

							int[,] Matriz_resultado = new int[m, n];

							for (int i = 0; i < m; i++)
							{
								for (int j = 0; j < n; j++)
								{
									Matriz_resultado[i, j] = Matriz_1[i, j] - Matriz_2[i, j];
								}
							}


							Console.WriteLine("La matriz resultante es : ");

							for (int i = 0; i < m; i++)
							{
								for (int j = 0; j < n; j++)
								{
									Console.Write(" " + Matriz_resultado[i, j] + " ");
								}
								Console.Write("\n");
							}
							Console.WriteLine("Presione cualquier tecla para volver al menú");
							Console.ReadKey();
							Console.Clear();
						}


						break;


					case 3:

						if (n != p)
						{
							Console.WriteLine("No se pueden multiplicar las matrices porque sus dimensiones son diferentes");
						}

						else
						{
							Console.WriteLine("La matriz resultante es : ");
							Console.WriteLine("");
							int suma = 0;
							int[,] Matriz_resultado = new int[m, q];

							for (int i = 0; i < m; i++)
							{

								for (int j = 0; j < q; j++)
								{
									suma = 0;
									for (int r = 0; r < n; r++)
									{
										suma = suma + (Matriz_1[i, r] * Matriz_2[r, j]);
									}
									Matriz_resultado[i, j] = suma;
								}

							}

							for (int i=0; i<m; i++)
                            {
								for (int j = 0; j < q; j++)
								{
									Console.Write(" " + Matriz_resultado[i, j] + " ");
								}
								Console.Write("\n");
							}
							
							

							Console.WriteLine("Presione cualquier tecla para volver al menú");
							Console.ReadKey();
							Console.Clear();
						}


						break;



					case 4:
						Console.Clear();
						Console.WriteLine("1. Multiplicar la primera matriz por un escalar.");
						Console.WriteLine("2. Multiplicar la segunda matriz por un escalar.");
						int opción_2 = 0;
						opción_2 = Convert.ToInt32(Console.ReadLine());

                        switch (opción_2)
                        {
							case 1:
								Console.WriteLine("Escriba el escalar por el que va a multiplicar la matriz: ");
								int escalar=Convert.ToInt32(Console.ReadLine());

									int[,] Matriz_resultado = new int[m, n];

									for (int i = 0; i < m; i++)
									{
										for (int j = 0; j < n; j++)
										{
										Matriz_resultado[i, j] = escalar*Matriz_1[i, j];
										}
									}


									Console.WriteLine("La matriz resultante es : ");

									for (int i = 0; i < m; i++)
									{
										for (int j = 0; j < n; j++)
										{
											Console.Write(" " + Matriz_resultado[i, j] + " ");
										}
										Console.Write("\n");
									}
									Console.WriteLine("Presione cualquier tecla para volver al menú");
									Console.ReadKey();
									Console.Clear();
								break;


							case 2:
								Console.WriteLine("Escriba el escalar por el que va a multiplicar la matriz: ");
								escalar = Convert.ToInt32(Console.ReadLine());

								Matriz_resultado = new int[p, q];

								for (int i = 0; i < p; i++)
								{
									for (int j = 0; j < q; j++)
									{
										Matriz_resultado[i, j] = escalar * Matriz_1[i, j];
									}
								}


								Console.WriteLine("La matriz resultante es : ");

								for (int i = 0; i < p; i++)
								{
									for (int j = 0; j < q; j++)
									{
										Console.Write(" " + Matriz_resultado[i, j] + " ");
									}
									Console.Write("\n");
								}
								Console.WriteLine("Presione cualquier tecla para volver al menú");
								Console.ReadKey();
								Console.Clear();


								break;

							default:
								Console.WriteLine ("La opción no es válida, presione cualquier tecla y volverá al menú.");
								Console.ReadKey();
								Console.Clear();

								break;

                        }

						break;

					case 5:
						Console.WriteLine("Adiós.");
						break;

					default:
						Console.WriteLine("La opción no es válida, presione cualquier tecla y volverá al menú.");
						Console.ReadKey();
						Console.Clear();
						break;

				}
            }
		}
    }
}
