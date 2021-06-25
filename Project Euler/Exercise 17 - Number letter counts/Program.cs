using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_17
{
    class Program
    {
        static string[] unitsNames = {"", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
                                "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};

        static string[] tensNames =  {"", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};


        static void Main()
        {
            int result = 0;
            string name;
            for (int i = 0; i <= 1000; i++)
            {
                name = "";
                if (i == 1000)
                {
                    name += "one thousand";
                }

                if (Math.Floor((float)i / 100) > 0 && Math.Floor((float)i / 100) < 10)
                {
                    name += unitsNames[(int)Math.Floor((float)i / 100)] + " hundred";
                    if (i % 100 != 0)
                    {
                        name += " and ";
                    }
                }

                if (i % 100 < 20)
                {
                    name += unitsNames[i % 100];
                }
                else if (i % 100 >= 20)
                {
                    name += tensNames[(int)Math.Floor((float)i / 10) % 10] + " " + unitsNames[i % 10];
                }
                
                Console.WriteLine(name);
                if (i == 200)
                {
                    Console.ReadLine();
                }

                result += numberNameCount(name);
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int numberNameCount (string numberName)
        {
            int result = 0;
            numberName = numberName.Replace(" ", string.Empty);
            result = numberName.Count();
            return result;
        }
    }
}
