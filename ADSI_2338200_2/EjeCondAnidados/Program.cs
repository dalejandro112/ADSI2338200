using System;

namespace EjeCondAnidados
{
    class Program
    {
        static void MainA(string[] args)
             /*  Dado tres números calcular el mayor */
        {
            {

                int a;
                int b;
                int c;
                Console.WriteLine("Dar valor A");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dar valor B");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dar valor C");
                c = Convert.ToInt32(Console.ReadLine());

                if (a < b)
                {
                    if (b < c)
                    {
                        Console.WriteLine("{0} es mayor", c);
                    }
                    else
                        Console.WriteLine("{0} es mayor", b);
                }
                else if (a > b)
                {
                    if (a < c)
                    {
                        Console.WriteLine("{0} es mayor", c);
                    }
                    else
                        Console.WriteLine("{0} es mayor", a);
                }
                Console.ReadKey();
            }
        }
    }

}
                       
                        
                    
                
            
      