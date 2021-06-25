using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    class Program
    {
        static void Main()
        {
            int d = int.Parse(Console.ReadLine());

            int divisors = 0;
            int triangleN = 0;
            int i = 1;
            while(divisors <= d)
            {
                triangleN += i;
                divisors = FindDivisors(triangleN);

                Console.WriteLine("{0} Triangle number is {1} with {2} divisors", i, triangleN, divisors);
                i++;
            }

            Console.WriteLine(triangleN);
            Console.ReadLine();
        }

        public static int FindDivisors (int triangle)
        {

            List<int> primes = new List<int>();
            primes.Add(0);

            int n = 2;
            int i = 0;

            while (triangle != 1)
            {
                if (triangle % n == 0)
                {
                    triangle /= n;

                    primes[i]++;
                }
                else
                {
                    n++;
                    primes.Add(0);
                    i++;
                }
            }

            return NumberOfDivisors(primes);
        }

        public static int NumberOfDivisors(List<int> arr)
        {
            int result = 1;

            foreach(int n in arr)
            {
                result *= (n + 1);
            }

            return result;
        }
    }
}
