using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_25
{
    class Program
    {
        static void Main()
        {

            string numberS = "";
            BigInteger a = 1;
            BigInteger b = 1;
            BigInteger t = 0;
            int n = 2;

            while (numberS.Length < 1000)
            {
                a = a + b;
                numberS = a.ToString();

                t = a;
                a = b;
                b = t;
                n++;

                Console.WriteLine(a)
            }

            Console.WriteLine("The first 1000 digit Fibonacci is in the {0}th position", n);
            Console.ReadLine();

        }
    }
}
