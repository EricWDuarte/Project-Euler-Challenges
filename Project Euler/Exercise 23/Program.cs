using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_23
{
    class Program
    {
        public static List<int> primeNumbers = new List<int>();

        static void Main()
        {
            primeNumbers = GetPrimeNumbers(28124);

            HashSet<int> abundantNumbers = new HashSet<int>();
            List<int> notPairSumAbundant = new List<int>();

            for (int i = 12; i <= 28123; i++)
            {
                if (GetDivisors(i).Sum() > i)
                {
                    abundantNumbers.Add(i);
                }
            }

            int m = 0;
            bool hasPair = false;

            for (int i = 1; i <= 28123; i++)
            {
                hasPair = false;

                foreach (int n in abundantNumbers)
                {
                    m = i - n;
                    if (m < 0)
                    {
                        break;
                    }

                    if (abundantNumbers.Contains(m))
                    {
                        hasPair = true;
                        break;
                    }
                }

                if (hasPair == false)
                {
                    notPairSumAbundant.Add(i);
                    Console.WriteLine(i);
                }
            }


            long result = notPairSumAbundant.Sum();
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static List<int> GetDivisors (int number)
        {
            List<int> result = new List<int>();
            List<int> temp = new List<int>();
            int n = number;

            result.Add(1);
            int i = 0;
            while (n > 1)
            {
                if(n % primeNumbers[i] == 0)
                {
                    n /= primeNumbers[i];
                    temp = new List<int>(result);

                    foreach(int d in temp)
                    {
                        if (d * primeNumbers[i] < number && result.Contains(d * primeNumbers[i]) == false)
                            result.Add(d * primeNumbers[i]);
                    }
                }
                else
                {
                    i++;
                }
            }
            return result;
        }

        public static List<int> GetPrimeNumbers(int LessThan)
        {
            List<int> result = new List<int>();
            result.Add(2);
            int i = 2;
            bool isPrime = true;

            while(i < LessThan)
            {
                isPrime = true;

                foreach (int prime in result)
                {
                    if (i % prime == 0)
                        isPrime = false;
                }

                if (isPrime)
                    result.Add(i);

                i++;
            }

            return result;
        }
    }
}
