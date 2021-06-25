using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_27
{
    class Program
    {

        public static List<int> primes = new List<int>();


        static void Main(string[] args)
        {

            primes.Add(2);

            int biggest = 0;
            int x = 0, y = 0;

            int maxA = 1000, maxB = 1000;

            for (int a = -maxA + 1; a < maxA; a++)
            {
                for (int b = -maxB + 1; b < maxB; b++)
                {
                    bool prime = true;
                    int n = 0;
                    int result = 0;

                    while(prime == true)
                    {
                        result = (n * n) + (n * a) + b;

                        if(n < 0)
                        {
                            continue;
                        }

                        if(result > primes.Last())
                        {
                            AddPrimes(result);
                        }

                        if (primes.Contains(result))
                        {
                            n++;
                        }
                        else
                        {
                            prime = false;

                            if (n > biggest)
                            {
                                biggest = n;
                                x = a;
                                y = b;

                                Console.WriteLine(n + " " + a + " " + b);
                            }
                        }
                    }     
                }
            }

            Console.WriteLine("a = " + x + ", b = " + y + ", a*b = " + x * y + " with " + biggest + " consecutive primes");
            Console.ReadLine();
        }

        public static void AddPrimes(int n)
        {
            int d = primes.Last();
            d++;

            while (d <= n)
            {
                bool isAPrimeNumber = true;

                foreach (int prime in primes)
                {
                    if (d % prime == 0)
                    {
                        isAPrimeNumber = false;
                    }
                }

                if (isAPrimeNumber)
                {
                    primes.Add(d);
                    Console.WriteLine("new prime: " + d);
                }

                d++;
            }           
        }
    }
}
