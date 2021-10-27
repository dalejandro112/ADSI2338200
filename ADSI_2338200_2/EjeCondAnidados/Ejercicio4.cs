using System;
using System.Collections.Generic;
using System.Text;

namespace EjeCondAnidados
{
    class Ejercicio4
    {
        static void MainT(string[] args)
        {
            /*  En un montallantas se ha establecido una promoción de las llantas marca “Ponchadas”, dicha promoción 
             * consiste en lo siguiente:
             *Si se compran menos de cinco llantas el precio es de $90000 cada una, de $80000 si se compran de cinco a 10 
             *y de $70000 si se compran más de 10. Obtener la cantidad de dinero que una persona tiene que pagar por cada         
             *una de las llantas que compra y la que tiene que pagar por el total de la compra */
            int numero_de_llantas, precio_por_llanta, total_De_la_compra;
            Console.WriteLine("ingrese el numero de llantas que va a comprar");
            numero_de_llantas = int.Parse(Console.ReadLine());
            precio_por_llanta = 90000;
            if (numero_de_llantas >= 5 && numero_de_llantas <= 10)
                precio_por_llanta = 80000;
            if (numero_de_llantas > 10)
                precio_por_llanta = 70000;
            total_De_la_compra = precio_por_llanta * numero_de_llantas;
            Console.WriteLine("valor depreioc por llanta:" + precio_por_llanta);
            Console.WriteLine("valor de total de la compra:" + total_De_la_compra);
            Console.WriteLine("presione una tecla para terminar");
            Console.ReadKey();
         

        }

                
    }
}
