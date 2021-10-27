using System;
using System.Collections.Generic;
using System.Text;

namespace EjeCondAnidados
{
    class Ejercicio5
    {
        static void MainT(string[] args)
        {
            /* Una frutería ofrece las manzanas con descuento según la siguiente tabla:
             
             NUM. DE KILOS COMPRADOS | % DESCUENTO
             0 - 2                   |0
             2.01 - 5                |10
             5.01 - 10               |15
             10.01 en adelante       |20

             Determinar cuanto pagara una persona que compre manzanas es esa frutería sabiendo que el kilo vale $1300 */

            double descuento, kilos_comprados, precio_por_kilo, subtotal, total;
            Console.Write("Ingresa el valor de kilos comprados: ");
            kilos_comprados = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de precio por kilo: ");
            precio_por_kilo = double.Parse(Console.ReadLine());
            descuento = 0;
            subtotal = kilos_comprados * precio_por_kilo;
            if (kilos_comprados > 2 && kilos_comprados <= 5)
                descuento = subtotal * 0.1;
            if (kilos_comprados > 5 && kilos_comprados <= 10)
                descuento = subtotal * 0.15;
            if (kilos_comprados > 10)
                descuento = subtotal * 0.2;
            total = subtotal - descuento;
            Console.WriteLine("Valor de descuento: " + descuento);
            Console.WriteLine("Valor de subtotal: " + subtotal);
            Console.WriteLine("Valor de total: " + total);
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}


