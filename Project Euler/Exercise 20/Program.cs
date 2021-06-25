using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_20
{
    class Program
    {
        static void Main()
        {
            BigInteger n = 1;
            int result = 0;
            for (int i = 1; i <= 100; i++)
            {
                n *= i;
            }

            string s = n.ToString();

            while(s.Length > 0)
            {
                result += int.Parse(s.Substring(0, 1));
                s = s.Remove(0, 1);
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
