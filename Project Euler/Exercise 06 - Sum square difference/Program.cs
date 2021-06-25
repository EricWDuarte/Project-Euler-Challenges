using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        public static void Main()
        {

            Console.WriteLine("Select the ending sum number: ");
            int n = int.Parse(Console.ReadLine());
            long squareSum = 0;
            long sumSquare = 0;

            for (int i = 1; i <= n; i++)
            {
                squareSum += i * i;
                sumSquare += i;
            }

            sumSquare *= sumSquare;

            Console.WriteLine("Diference = {0}", sumSquare - squareSum);
            Console.ReadLine();
        }
        
    }
}
