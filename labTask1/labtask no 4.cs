using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTask1
{
    class labtask_no_4
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Enter first number (a): ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number (b): ");
            b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("\nAfter swapping:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            Console.ReadLine();
        }
    }
}
