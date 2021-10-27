using System;
using System.Collections.Generic;
using System.Text;

namespace EjeCondAnidados
{
    class Ejercicio2
    {
        static void MainT(string[] args)
        {
            /* Dado el monto de una compra calcular el descuento considerado
            • Descuento es 20% si el monto es mayor a 20000 pesos.
            • Descuento es 10% si el monto es mayor a 10000 pesos y menor o igual a 20000 pesos.
            • no hay descuento si el monto es menor o igual a 10000 pesos.*/

            double N, monto;
            Console.WriteLine("Ingrese monto de compra");
            N = Convert.ToDouble(Console.ReadLine());
            if (N > 100)
            {
                monto = N - (N * 0.2);
                Console.WriteLine(monto);
            }
            else
            {
                if (N <= 100 && N > 50)
                {
                    monto = N - (N * 0.1);
                    Console.WriteLine(monto);
                }
                else
                {
                    Console.WriteLine(N);
                }
            }
            Console.ReadLine();
        }
    }
}
