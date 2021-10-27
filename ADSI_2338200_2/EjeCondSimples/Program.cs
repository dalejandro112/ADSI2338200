using System;

namespace EjeCondSimples
{
    class Program
    {
        static void MainT(string[] args)
        {
            /*  El jefe del personal de operación de la industria aceitera Móvil desea calcular el sueldo neto de sus 
             *empleados bajo las siguientes normas, solicitar el nombre del empleado, número de horas trabajadas 
             *y la cuota por hora trabajada, para calcular el sueldo neto del empleado, se le otorga un incentivo del 
             *5% si el empleado trabajó más de 40 horas. Imprimir el nombre del empleado y su sueldo. Desarrollar 
             *el algoritmo y diagrama de flujo. */
            Console.WriteLine("\ningresa el nombre del empleado ");
            string nombre = Console.ReadLine();
            
            Console.WriteLine("\ningrese el numero de horas trabajadas ");
            double  horas  = int.Parse(Console.ReadLine());
          
            Console.WriteLine("\ningrese cuota por hora trabajada ");
            double cuota = int.Parse(Console.ReadLine());
           
            double salario_bruto = cuota * horas;
          
            double impuestos  = salario_bruto * 0.1;
            
            double salario_neto = salario_bruto - impuestos;
            
            double salario_final;
            if (horas > 40)
            {
                 salario_final = salario_neto * 0.5 + salario_neto;
               
                
            }
            else
            {
                salario_final = salario_neto;
                
            }
            Console.WriteLine("el nombre del empleado es" + nombre);
            Console.WriteLine("el salario del empleado es" + salario_final);


        }
    }
}
