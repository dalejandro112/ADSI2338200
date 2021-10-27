using System;
using System.Collections.Generic;
using System.Text;

namespace EjeCondAnidados
{
    class Ejercicio3
    {
        static void MainT(string[] args)
        {

            /*En una fábrica de computadoras se planea ofrecer a los clientes un descuento que dependerá del número de
            computadoras que compre.Si las computadoras son menos de cinco se les dará un 10 % de descuento sobre el
            total de la compra; si el número de computadoras es mayor o igual a cinco pero menos de diez se le otorga un
            20 % de descuento; y si son 10 o más se les da un 40 % de descuento.El precio de cada computadora es de
            $1100000*/



            double descuento, numero_de_computadoras, total_de_la_compra;
            Console.Write("Ingresa el valor de numero de computadoras: ");
            numero_de_computadoras = double.Parse(Console.ReadLine());
            descuento = 0;
            total_de_la_compra = numero_de_computadoras * 3000;
            if (numero_de_computadoras < 5)
                descuento = total_de_la_compra * 0.1;
            if (numero_de_computadoras >= 5 && numero_de_computadoras < 10)
                descuento = total_de_la_compra * 0.2;
            if (numero_de_computadoras >= 10)
                descuento = total_de_la_compra * 0.4;
            Console.WriteLine("Valor de descuento: " + descuento);
            Console.WriteLine("Valor de total de la compra: " + total_de_la_compra);
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();






        }
    }
}
