using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_30
{
    class Program
    {
        static void Main()
        {
            List<int> PerfectNumbers = new List<int>();
            int result = 0;

            for (int i = 2; i < 400000; i++)
            {
                if (IsPerfect(i.ToString()))
                {
                    PerfectNumbers.Add(i);
                }
                Console.WriteLine(i);
            }

            foreach (int n in PerfectNumbers)
            {
                result += n;
                Console.WriteLine(n);
            }

            Console.WriteLine("Result: " + result);

            Console.Read();
        }

        public static List<int> GetDigits(int n)
        {
            List<int> result = new List<int>();

            return result;
        }

        public static bool IsPerfect(string n)
        {
            bool result = false;
            int value = 0;

            for (int i = 0; i < n.Length; i++)
            {
                value += NaQuinta(int.Parse(n.Substring(i, 1)));
            }

            if (value == int.Parse(n))
            {
                result = true;
            }


                return result;
        }

        public static int NaQuinta(int n)
        {
            return n * n * n * n * n;
        }
    }
}