using System;
using System.Collections;

public class Program
{
    static void Main()
    {
        float n = 0;
        int result = 0;

        ArrayList multiples3n5 = new ArrayList();

        for (int i = 0; i < 1000; i++)
        {
            n = i;
            if (n % 15 == 0)
            {
                multiples3n5.Add(i);
            }
            else if (n % 5 == 0)
            {
                multiples3n5.Add(i);
            }
            else if (n % 3 == 0)
            {
                multiples3n5.Add(i);
            }
        }

        foreach (int number in multiples3n5)
        {
            Console.WriteLine(number);
            result += number;
        }

        Console.WriteLine(result);
    }
}
