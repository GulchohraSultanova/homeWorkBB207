using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class task2
    {
        static void Main(string[] args)
        {
            //task1:Ededin reqemleri hasilini tapin.
            int n = 123, has = 1;
            while (n != 0)
            {
                has *= n % 10;
                n = n / 10;
            }
            Console.WriteLine(has);
            //

            //task2:Verilmis ededin sade ve ya murekkeb oldugunu tapan alqoritm
            int a = 5, sum = 0, i = 2;

            while (i <= a)
            {
                if (a % i == 0)
                {

                    if (a == i)
                    {
                        Console.WriteLine("Number is  prime");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Number is not prime");
                        break;
                    }
                }
                else
                {
                    i++;
                }
            }
            //

            //task3:Verilmis ededin faktorialini tapin
            int m = 5, fak = 1;
            for (int j = 1; j <= m; j++)
            {
                fak *= j;

            }
            Console.WriteLine(fak);
            //

            //task4:Verilmis ededn polindrom olub olmadigini yoxlayin.
            int b = 1221, k = 0, c = b;
            while (b != 0)
            {
                k = k * 10 + b % 10;
                b = b / 10;
            }
            if (c == k)
            {

                Console.WriteLine("Number is polindrome");
            }
            else
            {
                Console.WriteLine("Number is not polindrome");
            }

        }

    }
}