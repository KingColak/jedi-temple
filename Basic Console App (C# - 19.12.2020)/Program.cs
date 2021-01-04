using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Basics_SametColak_Lunes
{
    class Program
    {
        static void Main(string[] args)
        {       
                //Asceding numbers from 1 to 100
                Console.WriteLine("ASCENDING FROM 1 TO 100");
                int x = 0;
                while (x < 100)
                {
                    x++;
                    Console.WriteLine(x);
                }

                //Descending numbers from 100 to 1
                Console.WriteLine("DESCENDING FROM 100 TO 1");
                int y = 100;
                while (y > 0)
                {
                    y--;
                    Console.WriteLine(y);
                }

                Console.WriteLine("---> SUM OF NUMBERS FROM 1 TO 'N' <---");

                //Version #1 (for-loop)
                int t1 = 1;
                Console.WriteLine("PLEASE INPUT 'N': ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                int sum1 = 0;
                if (n1 > 0)
                {
                    for (int i = t1; t1 <= n1; t1++)
                    {
                    sum1 += t1;
                    }
                }
                else
                {
                Console.WriteLine("SUM IS 'ZERO (0)'");
                }
                Console.WriteLine("SUM OF NUMBERS FROM 1 TO {0} IS {1}", n1, sum1);

                //Version #2 (while-loop)
                int t2 = 1;
                Console.WriteLine("PLEASE INPUT 'N': ");
                int n2 = Convert.ToInt32(Console.ReadLine());
                int sum2 = 0;
                if (n2 > 0)
                {
                    while (t2 <= n2)
                    {
                        sum2 += t2;
                        t2++;
                    }
                    Console.WriteLine("SUM OF NUMBERS FROM 1 TO {0} IS {1}", n2, sum2);
                }
                else
                {
                    Console.WriteLine("SUM IS 'ZERO (0)'");
                }            
        }
    }  
}  