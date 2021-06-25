using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_22
{
    class Program
    {
        static void Main()
        {
            long result = 0;

            string text = System.IO.File.ReadAllText(@"C:\Users\Eric\Desktop\Programming Exercises\Exercise 22\Names.txt");
            text = text.Replace("\"", string.Empty);
            string[] names = text.Split(',');
            IOrderedEnumerable<string> sortedNames = names.OrderBy(n => n);

            for (int i = 0; i < sortedNames.Count(); i++)
            {
                result += GetScore(sortedNames.ElementAt(i)) * (i + 1);
                Console.WriteLine(i + " of " + sortedNames.Count());
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int GetScore(string s)
        {
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                result += char.Parse(s.Substring(i, 1)) - 64;
            }

            return result;
        }
    }
}
