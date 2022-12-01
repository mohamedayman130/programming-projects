using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<<<<type no to exit and 0 to continue>>>>");
         rr:   int n; Console.Write("enter your number ::>>"); n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }
                for (int k = 1; k <= 2 * n - 2 * i; k++)
                {

                    Console.Write(' ');

                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }





                Console.WriteLine();
            }

            int o=0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write("*");

                }
                for (int k =0; k <o; k += 1)
                {

                    Console.Write(' ');
                    

                }
                o += 2;
                for (int j = i; j <= n; j++)
                {
                    Console.Write("*");

                }





                Console.WriteLine();
            }
for(float i = 1;i <= n/2; i++)
            { Console.Write(' ');}
Console.WriteLine("ALFANAN_02");
            string end;
            end=Console.ReadLine();
            if (end=="0")
            {
                goto rr;
            }







        }
    }
}
