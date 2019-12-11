using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace program
{
    class Program////Using for loop we are computing the sum of the number till the Nth number. Print the sum of the elements.///
    {
        static void Main(string[] args)
        {
            int i, sum = 0, n;
            Console.Write("Enter the Nth Number : ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("\nSum of N Numbers : " + sum);
            Console.ReadLine();

        }
    }
}
////Output:
///Enter the Nth Number : 5
///Sum of N Numbers : 15