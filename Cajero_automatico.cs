using System;

namespace Ejercicio_4.__Cajero_electrónico
{
    class Program
    {
        static void Main(string[] args)
        {
            int dinero_total = 5000000;
            int billetes_50 = Convert.ToInt32((5000000*0.5)/50000);
            int billetes_20 = Convert.ToInt32((5000000* 0.3 )/ 20000);
            int billetes_10 = Convert.ToInt32((5000000 * 0.2) / 10000);
            int billetes_50_entregado = 0;
            int billetes_20_entregado = 0;
            int billetes_10_entregado = 0;
            int monto_a_sacar = 0;
            int opción = 0;
          
            int módulo = 0;

           

            while (opción != 2)
            {
                Console.WriteLine("BIENVENIDO A TU CAJERO ELECTRÓNICO");
                Console.WriteLine("1. Retirar dinero.");
                Console.WriteLine("2. Salir del cajero.");
                opción = Convert.ToInt32(Console.ReadLine());


                switch (opción)
                {
                    case 1:
                        Console.WriteLine("Por favor ingrese el monto que desea retirar. (Máximo 600.000): ");
                        monto_a_sacar = Convert.ToInt32(Console.ReadLine());

                        if(monto_a_sacar>600000)
                        {
                            Console.WriteLine("El monto solicitado supera el monto máximo posible. Por favor ingrese un monto permitido: ");
                            System.Threading.Thread.Sleep(3000);;
                            Console.Clear();
                            break;
                        }

                        if (monto_a_sacar > dinero_total)
                        {
                            Console.WriteLine("El cajero no tiene dinero suficiente para esta transacción en este momento.");
                            System.Threading.Thread.Sleep(3000);;
                            Console.Clear();
                            break;
                        }

                        if (monto_a_sacar%10000 != 0) 
                        {
                            Console.WriteLine("El monto no puede ser entregado. Use montos múltiplos de 10000");
                            System.Threading.Thread.Sleep(3000);;
                            Console.Clear();
                            break;
                        }





                        if (monto_a_sacar > 50000)
                        {

                            if (billetes_10>0 && billetes_20 > 1)
                            {

                                monto_a_sacar = monto_a_sacar - 50000;
   

                                if (billetes_50 >= 0)
                                {
                                    billetes_50_entregado = monto_a_sacar / 50000;
                                    if (billetes_50 >= billetes_50_entregado)
                                    {
                                        monto_a_sacar = monto_a_sacar - (billetes_50_entregado * 50000);
                                       
                                    }
                                    if (billetes_50 < billetes_50_entregado)
                                    {
                                        monto_a_sacar = monto_a_sacar - (billetes_50 * 50000);
                                        billetes_50_entregado = billetes_50;
                                        
                                    }

                                    
                                }

                                if (billetes_20 >= 0)
                                {
                                    billetes_20_entregado = monto_a_sacar / 20000;
                                    if (billetes_20 >= billetes_20_entregado)
                                    {
                                        monto_a_sacar = monto_a_sacar - (billetes_20_entregado * 20000);
                                       
                                    }
                                    if (billetes_20 < billetes_20_entregado)
                                    {
                                        monto_a_sacar = monto_a_sacar - (billetes_20 * 20000);
                                        billetes_20_entregado = billetes_20;
                                        
                                    }


                                }




                                if (billetes_10 >= 0)
                                {
                                    billetes_10_entregado = monto_a_sacar / 10000;
                                    if (billetes_10 >= billetes_10_entregado)
                                    {
                                        monto_a_sacar = monto_a_sacar - (billetes_10_entregado * 10000);
                                        
                                    }
                                    if (billetes_10 < billetes_10_entregado)
                                    {
                                        monto_a_sacar = monto_a_sacar - (billetes_10 * 10000);
                                        billetes_10_entregado = billetes_10;
                                       
                                    }
                                }


                                if (monto_a_sacar == 0)
                                {
                                    billetes_50 = billetes_50 - billetes_50_entregado;
                                    billetes_20 = billetes_20 - billetes_20_entregado;
                                    billetes_10 = billetes_10 - billetes_10_entregado;
                                    billetes_20 = billetes_20 - 2;
                                    billetes_10 = billetes_10 - 1;
                                    billetes_10_entregado = billetes_10_entregado + 1;
                                    billetes_20_entregado = billetes_20_entregado + 2;

                                    Console.WriteLine("Entrego: " + billetes_10_entregado + " billetes de 10.000, "+ billetes_20_entregado + " billetes de " +
                                        "20.000 y " + billetes_50_entregado + " billetes de 50.000. ");
                                    System.Threading.Thread.Sleep(3000);;
                                    Console.Clear();
                                    break;
                                }

                                else if (monto_a_sacar != 0)
                                {
                                    Console.WriteLine("No hay billetes para entregar el valor solicitado. ");
                                    System.Threading.Thread.Sleep(3000);;
                                    Console.Clear();
                                    break;
                                }


                                }




                                else if (billetes_10 < 0 || billetes_20 < 1)
                                {


                                    if (billetes_50 >= 0)
                                    {
                                        billetes_50_entregado = monto_a_sacar / 50000;
                                        if (billetes_50 >= billetes_50_entregado)
                                        {
                                            monto_a_sacar = monto_a_sacar - (billetes_50_entregado * 50000);
                                            
                                        }
                                        if (billetes_50 < billetes_50_entregado)
                                        {
                                            monto_a_sacar = monto_a_sacar - (billetes_50 * 50000);
                                            billetes_50_entregado = billetes_50;
                                        }

                                    }



                                    if (billetes_20 >= 0)
                                    {
                                        billetes_20_entregado = monto_a_sacar / 20000;
                                        if (billetes_20 >= billetes_20_entregado)
                                        {
                                            monto_a_sacar = monto_a_sacar - (billetes_20_entregado * 20000);
                                           
                                        }
                                        if (billetes_20 < billetes_20_entregado)
                                        {
                                            monto_a_sacar = monto_a_sacar - (billetes_20 * 20000);
                                            billetes_20_entregado = billetes_20;
                                            
                                        }

                                     

                                    }




                                    if (billetes_10 >= 0)
                                    {
                                        billetes_10_entregado = monto_a_sacar / 10000;
                                        if (billetes_10 >= billetes_10_entregado)
                                        {
                                            monto_a_sacar = monto_a_sacar - (billetes_10_entregado * 10000);
                                            
                                        }
                                        if (billetes_10 < billetes_10_entregado)
                                        {
                                            monto_a_sacar = monto_a_sacar - (billetes_10 * 10000);
                                            billetes_10_entregado = billetes_10;
                                            
                                        }

                                    }

                                if (monto_a_sacar == 0)
                                {
                                    billetes_50 = billetes_50 - billetes_50_entregado;
                                    billetes_20 = billetes_20 - billetes_20_entregado;
                                    billetes_10 = billetes_10 - billetes_10_entregado;

                                    Console.WriteLine("Entrego: " + billetes_10_entregado + "billetes de 10.000, " + billetes_20_entregado + "billetes de " +
                                        "20.000 y " + billetes_50_entregado + "billetes de 50.000. ");
                                    System.Threading.Thread.Sleep(3000);;
                                    Console.Clear();
                                    break;
                                }

                                else if (monto_a_sacar != 0)
                                {
                                    Console.WriteLine("No hay billetes para entregar el valor solicitado. ");
                                    System.Threading.Thread.Sleep(3000);;
                                    Console.Clear();
                                    break;
                                }






                            }


                        }
                          







                        if (monto_a_sacar == 50000)
                        {
                            if (billetes_50 > 0)
                            {
                                Console.WriteLine("Entrego: 1 billete de 50000");
                                billetes_50 = billetes_50 - 1;
                                dinero_total = dinero_total - 50000;
                                System.Threading.Thread.Sleep(3000);;
                                Console.Clear();
                                break;
                            }

                            if (billetes_10 > 0 && billetes_20 > 1)
                            {
                                Console.WriteLine("Entrego: 2 billetes de 20000 y 1 de 10000");
                                billetes_10 = billetes_10 - 1;
                                billetes_20 = billetes_20 - 2;
                                dinero_total = dinero_total - 50000;
                                System.Threading.Thread.Sleep(3000);;
                                Console.Clear();
                                break;
                            }

                            if (billetes_10 > 4)
                            {
                                Console.WriteLine("Entrego: 5 billetes de 10000");
                                billetes_10 = billetes_10 - 5;
                                dinero_total = dinero_total - 50000;
                                System.Threading.Thread.Sleep(3000);;
                                Console.Clear();
                                break;
                            }

                            Console.WriteLine("No se cuenta con los billetes para entregar este monto.");
                            System.Threading.Thread.Sleep(3000);;
                            Console.Clear();
                            break;
                        }




                        if (monto_a_sacar< 50000)
                        {
                            if (monto_a_sacar % 20000 == 0 && billetes_20 >= (monto_a_sacar/20000))
                            {
                                billetes_20_entregado = monto_a_sacar / 20000;
                                Console.WriteLine("Entrego: " + billetes_20_entregado.ToString() + " billetes de 20000.");
                                dinero_total = dinero_total - monto_a_sacar;
                                System.Threading.Thread.Sleep(3000);;
                                Console.Clear();
                                break;
                            }


                            if (monto_a_sacar % 20000 != 0 && billetes_20 >= ((monto_a_sacar-10000)/ 20000))
                            {
                                billetes_10_entregado = 1;
                                billetes_20_entregado = (monto_a_sacar - 10000) / 20000;

                                Console.WriteLine("Entrego: " + billetes_10_entregado.ToString() + " billetes de 10000 y " +
                                    billetes_20_entregado.ToString() + "billetes de 20000.");
                                dinero_total = dinero_total - monto_a_sacar;
                                System.Threading.Thread.Sleep(3000);;
                                Console.Clear();
                                break;
                            }

                            if (monto_a_sacar % 20000 != 0 && billetes_10 >= (monto_a_sacar / 10000))
                            {

                                billetes_10_entregado = monto_a_sacar / 10000;

                                Console.WriteLine("Entrego: " + billetes_10_entregado.ToString() + " billetes de 10000.");
                                dinero_total = dinero_total - monto_a_sacar;
                                System.Threading.Thread.Sleep(3000);;
                                Console.Clear();
                                break;
                            }

                            Console.WriteLine("No se cuenta con los billetes para entregar este monto.");
                            System.Threading.Thread.Sleep(3000);;
                            Console.Clear();
                            break;
                        }

                        break;

                    case 2:

                        Console.WriteLine("Bye bye. No joda");

                        System.Threading.Thread.Sleep(3000);

                        break;

                }
            }
        }
    }
}
