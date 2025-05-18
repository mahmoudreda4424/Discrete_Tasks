using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            bool result = true;

            Console.Write("Inter the first number :");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Inter the second number :");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The prime number between " + num1 + " and " + num2 + " is : ");

            for (i = num1; i <= num2; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        result = false;


                }
                if (result == true && i != 1 && i != 0)
                {
                    Console.WriteLine(i);
                }
                result = true;
            }
        }
    } 
}
