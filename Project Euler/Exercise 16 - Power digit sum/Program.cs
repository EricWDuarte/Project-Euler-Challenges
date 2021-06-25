using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_16
{
    class Program
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());

            BigInteger n = 1;
            string s;
            BigInteger sum = 0;

            for (int i = 0; i < x; i++)
            {
                n *= 2;
            }

            s = n.ToString();

            while (s.Length > 0)
            {
                sum += BigInteger.Parse(s.Substring(0, 1));
                s = s.Remove(0, 1);
            }

            Console.WriteLine("sum = {0}", sum);
            Console.ReadLine();

        }
    }
}
